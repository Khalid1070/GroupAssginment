using System;
using System.IO;
using System.Windows.Forms;

namespace GroupAssginment
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblError.Visible = false;
        }

        // ---------------------------------------------------------------
        // Validate email using string methods (Chapter 8 – Gaddis)
        //   Rules:
        //   • Must contain '@'
        //   • Something must appear before '@'
        //   • The domain part (after '@') must NOT start with '.'
        //   • The domain part must contain at least one '.'
        //   • Must have characters after the last '.'
        //   Valid:   Mohammed@stu.edu  |  202112345@kfupm.edu.sa
        //   Invalid: myemail.com  |  Ali@domain  |  Sultan@.com
        // ---------------------------------------------------------------
        private bool IsValidEmail(string email)
        {
            // Must contain '@'
            if (!email.Contains("@"))
                return false;

            int atIndex = email.IndexOf("@");

            // Must have at least one character before '@'
            if (atIndex == 0)
                return false;

            // Get the part after '@'
            string domain = email.Substring(atIndex + 1);

            // Domain must not be empty and must not start with '.'
            if (domain.Length == 0 || domain.StartsWith("."))
                return false;

            // Domain must contain a '.' (needs subdomain.tld)
            if (!domain.Contains("."))
                return false;

            // Must have at least one character after the last '.'
            int lastDotIndex = domain.LastIndexOf(".");
            if (lastDotIndex == domain.Length - 1)
                return false;

            return true;
        }

        // ---------------------------------------------------------------
        // Validate password using a loop and char comparisons (Ch. 4, 5)
        //   Rules:
        //   • At least 7 characters
        //   • At least 2 uppercase letters
        //   • At least 2 lowercase letters
        //   • At least 1 digit
        //   Valid:   ABcdex1  |  QWerty7
        //   Invalid: Abcde1  |  abcdefg1  |  ABCDEFG1
        // ---------------------------------------------------------------
        private bool IsValidPassword(string password)
        {
            if (password.Length < 7)
                return false;

            int upperCount = 0;
            int lowerCount = 0;
            int digitCount = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];

                if (c >= 'A' && c <= 'Z')
                    upperCount++;
                else if (c >= 'a' && c <= 'z')
                    lowerCount++;
                else if (c >= '0' && c <= '9')
                    digitCount++;
            }

            return upperCount >= 2 && lowerCount >= 2 && digitCount >= 1;
        }

        // ---------------------------------------------------------------
        // Sign Up button
        // ---------------------------------------------------------------
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblError.Visible = false;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem != null
                              ? cmbRole.SelectedItem.ToString()
                              : "";

            // ── Check all fields are filled ──────────────────────────
            if (username == "" || password == "" || role == "")
            {
                lblError.Text = "Please fill in all fields.";
                lblError.Visible = true;
                return;
            }

            // ── Validate email ───────────────────────────────────────
            if (!IsValidEmail(username))
            {
                lblError.Text = "Invalid email. Example: user@sub.domain";
                lblError.Visible = true;
                return;
            }

            // ── Validate password ────────────────────────────────────
            if (!IsValidPassword(password))
            {
                lblError.Text = "Password needs 7+ chars, 2 uppercase, 2 lowercase, 1 digit.";
                lblError.Visible = true;
                return;
            }

            // ── Check for duplicate username in users.txt ────────────
            if (File.Exists("users.txt"))
            {
                StreamReader checkFile = File.OpenText("users.txt");
                while (!checkFile.EndOfStream)
                {
                    string line = checkFile.ReadLine();
                    string[] parts = line.Split(',');
                    if (parts.Length >= 1 && parts[0] == username)
                    {
                        checkFile.Close();
                        lblError.Text = "Username already exists. Please choose another.";
                        lblError.Visible = true;
                        return;
                    }
                }
                checkFile.Close();
            }

            // ── Save new user to users.txt ───────────────────────────
            StreamWriter outputFile = new StreamWriter("users.txt", true); // true = append
            outputFile.WriteLine(username + "," + password + "," + role);
            outputFile.Close();

            // ── Success ──────────────────────────────────────────────
            MessageBox.Show("Account created successfully! You can now log in.",
                            "Sign Up Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.Close(); // Return to Login Form
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.SelectedIndex = -1;
            lblError.Text = "";
            lblError.Visible = false;
        }
    }
}