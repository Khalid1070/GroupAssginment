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
            lblSignUpError.Text = "";
            lblSignUpError.Visible = false;

            textBox_userName.Text = "Username (email)";  // Set placeholder text
            textBox_userName.ForeColor = System.Drawing.Color.Gray;

            textBox_pass.Text = "Password";  // Set placeholder text
            textBox_pass.ForeColor = System.Drawing.Color.Gray;

            comboBox1.Text = "Select Role";  // Set placeholder text
            comboBox1.ForeColor = System.Drawing.Color.Gray;
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

        private bool IsValidRole(string role)
        {
            return role == "Student" || role == "Faculty";
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_userName_Enter(object sender, EventArgs e)
        {
            textBox_userName.ForeColor = System.Drawing.Color.Black;
            if (textBox_userName.Text == "Username (email)")
            {
                textBox_userName.Text = "";
            }
        }

        private void textBox_userName_Leave(object sender, EventArgs e)
        {
           
            if (textBox_userName.Text.Trim() == "")
            {
                textBox_userName.ForeColor = System.Drawing.Color.Gray;
                textBox_userName.Text = "Username (email)";
            }
        }

        private void textBox_pass_Enter(object sender, EventArgs e)
        {
            textBox_pass.ForeColor = System.Drawing.Color.Black;
            if (textBox_pass.Text == "Password")
            {
                textBox_pass.Text = "";
            }
        }

        private void textBox_pass_Leave(object sender, EventArgs e)
        {
            
            if (textBox_pass.Text.Trim() == "")
            {
                textBox_pass.ForeColor = System.Drawing.Color.Gray;
                textBox_pass.Text = "Password";
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.ForeColor = System.Drawing.Color.Black;
            comboBox1.Text = "";
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.ForeColor = System.Drawing.Color.Gray;
                comboBox1.Text = "Select Role";
            }
        }


        private void button_LogIn_Click(object sender, EventArgs e)
        {
            lblSignUpError.Text = "";
            lblSignUpError.Visible = false;

            string username = textBox_userName.Text.Trim();
            string password = textBox_pass.Text.Trim();
            string role;

            if (comboBox1.SelectedItem != null)
            {
                role = comboBox1.SelectedItem.ToString();
            }
            else
            {
                role = "";
            }

            if (username == "" || password == "" || role == "")
            {
                lblSignUpError.Text = "Please fill in all fields.";
                lblSignUpError.Visible = true;
                return;
            }

            if (!IsValidEmail(username))
            {
                lblSignUpError.Text = "Invalid email. Example: user@sub.domain";
                lblSignUpError.Visible = true;
                return;
            }

            if (!IsValidPassword(password))
            {
                lblSignUpError.Text = "Password needs 7+ chars, 2 uppercase, 2 lowercase, 1 digit.";
                lblSignUpError.Visible = true;
                return;
            }

            if (!IsValidRole(role))
            {
                lblSignUpError.Text = "Please select a role";
                lblSignUpError.Visible= true;
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
                        lblSignUpError.Text = "Username already exists. Please choose another.";
                        lblSignUpError.Visible = true;
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

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_userName.Text = "";
            textBox_pass.Text = "";
            comboBox1.SelectedIndex = -1;
            lblSignUpError.Text = "";
            lblSignUpError.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Team Members:\nMuneeb Al Talaq - 202367270\nAnas Bendania - 202467940\nKhalid Alghamdi - 202185210",
                            "About");
        }
    }
}