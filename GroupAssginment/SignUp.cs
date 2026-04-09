using System;
using System.IO;
using System.Text.RegularExpressions;
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

        // -------------------------------------------------------
        // Validation: Email must have @ and subdomain.domain
        // e.g. user@sub.domain  or  202112345@kfupm.edu.sa
        // Invalid: myemail.com | Ali@domain | Sultan@.com
        // -------------------------------------------------------
        private bool IsValidEmail(string email)
        {
            // Must contain @
            // After @ must start with at least one alphanumeric char (no leading dot)
            // Must have at least one dot after @, with non-empty parts
            Regex emailRegex = new Regex(@"^[^@\s]+@[a-zA-Z0-9][a-zA-Z0-9\-]*(\.[a-zA-Z0-9\-]+)+$");
            return emailRegex.IsMatch(email);
        }

        // -------------------------------------------------------
        // Validation: Password rules
        //   - At least 7 characters
        //   - At least 2 uppercase letters
        //   - At least 2 lowercase letters
        //   - At least 1 digit
        // -------------------------------------------------------
        private bool IsValidPassword(string password)
        {
            if (password.Length < 7)
                return false;

            int upperCount = 0;
            int lowerCount = 0;
            int digitCount = 0;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) upperCount++;
                else if (char.IsLower(c)) lowerCount++;
                else if (char.IsDigit(c)) digitCount++;
            }

            return upperCount >= 2 && lowerCount >= 2 && digitCount >= 1;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblError.Visible = false;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem != null ? cmbRole.SelectedItem.ToString() : "";

            // --- Check all fields filled ---
            if (username == "" || password == "" || role == "")
            {
                ShowError("Please fill in all fields.");
                return;
            }

            // --- Validate email ---
            if (!IsValidEmail(username))
            {
                ShowError("Invalid email.\nMust be in the format: user@subdomain.domain\n(e.g. 202112345@kfupm.edu.sa)");
                return;
            }

            // --- Validate password ---
            if (!IsValidPassword(password))
            {
                ShowError("Invalid password.\nRequirements: at least 7 characters,\n2 uppercase letters, 2 lowercase letters, 1 digit.");
                return;
            }

            // --- Check for duplicate username ---
            if (File.Exists("users.txt"))
            {
                foreach (string line in File.ReadAllLines("users.txt"))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 1 && parts[0] == username)
                    {
                        ShowError("This username already exists. Please choose another.");
                        return;
                    }
                }
            }

            // --- Save to users.txt ---
            try
            {
                using (StreamWriter sw = File.AppendText("users.txt"))
                {
                    sw.WriteLine($"{username},{password},{role}");
                }
            }
            catch (Exception ex)
            {
                ShowError("Error saving account: " + ex.Message);
                return;
            }

            // --- Success ---
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

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }
    }
}