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


        private bool IsValidEmail(string email)
        {
            if (!email.Contains("@"))
                return false;

            int atIndex = email.IndexOf("@");

            if (atIndex == 0)
                return false;

            string domain = email.Substring(atIndex + 1);

            if (domain.Length == 0 || domain.StartsWith("."))
                return false;

            if (!domain.Contains("."))
                return false;

            int lastDotIndex = domain.LastIndexOf(".");
            if (lastDotIndex == domain.Length - 1)
                return false;

            return true;
        }


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


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblError.Visible = false;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem != null
                              ? cmbRole.SelectedItem.ToString()
                              : "";

            if (username == "" || password == "" || role == "")
            {
                lblError.Text = "Please fill in all fields.";
                lblError.Visible = true;
                return;
            }

            if (!IsValidEmail(username))
            {
                lblError.Text = "Invalid email. Example: user@sub.domain";
                lblError.Visible = true;
                return;
            }

            if (!IsValidPassword(password))
            {
                lblError.Text = "Password needs 7+ chars, 2 uppercase, 2 lowercase, 1 digit.";
                lblError.Visible = true;
                return;
            }

            string filePath = System.IO.Path.Combine(Application.StartupPath, "users.txt");

            if (File.Exists(filePath))
            {
                StreamReader checkFile = File.OpenText(filePath);
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

            StreamWriter outputFile = new StreamWriter(filePath, true); // true = append
            outputFile.WriteLine(username + "," + password + "," + role);
            outputFile.Close();

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