using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GroupAssginment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_login_error.Text = "";
            label_login_error.Visible = false;

            textBox_userName.Text = "Username";  // Set placeholder text
            textBox_userName.ForeColor = Color.Gray;

            textBox_pass.Text = "Password";  // Set placeholder text
            textBox_pass.ForeColor = Color.Gray;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

    

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            // Clear old error message
            label_login_error.Text = "";
            label_login_error.Visible = false;

            string username = textBox_userName.Text.Trim();
            string password = textBox_pass.Text.Trim();

            if (username == "Useername" || password == "Password")
            {
                label_login_error.Text = "Please enter both username and password.";
                label_login_error.Visible = true;
                return;
            }

            // Always resolve users.txt from the application's own folder
            string filePath = System.IO.Path.Combine(Application.StartupPath, "users.txt");

            if (!File.Exists(filePath))
            {
                label_login_error.Text = "No accounts found. Please sign up first.";
                label_login_error.Visible = true;
                return;
            }

            bool found = false;

            StreamReader inputFile = File.OpenText(filePath);
            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    string fileUser = parts[0];
                    string filePass = parts[1];
                    string job = parts[2];

                    if (username == fileUser && password == filePass)
                    {
                        found = true;
                        label_login_error.Text = "";
                        label_login_error.Visible = false;

                        if (job == "Student")
                        {
                            Student sForm = new Student(username);
                            sForm.ShowDialog();
                        }
                        else if (job == "Faculty")
                        {
                            Faculty fForm = new Faculty();
                            fForm.ShowDialog();
                        }
                        break;
                    }
                }
            }
            inputFile.Close();

            if (!found)
            {
                label_login_error.ForeColor = Color.Red;
                label_login_error.Text = "Invalid username or password.";
                label_login_error.Visible = true;
            }
        }

    

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Team Members:\nMuneeb Al Talaq - 202367270\nAnas Bendania - 202467940\nKhalid Alghamdi - 202185210",
                            "About");
        }

        // -------------------------------------------------------
        // LinkLabel: "Don't have an account? Sign Up"
        // Opens the Sign Up form
        // -------------------------------------------------------
        private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_userName_Enter(object sender, EventArgs e)
        {
            if (textBox_userName.Text == "Username")
            {
                label_login_error.Text = "";

                textBox_userName.Text = "";  // Clear placeholder text
                textBox_userName.ForeColor = Color.Black; // Change to normal text color
            }
        }

        private void textBox_userName_Leave(object sender, EventArgs e)
        {
            if (textBox_userName.Text == "")
            {
                textBox_userName.Text = "Username";  // Reset to placeholder text
                textBox_userName.ForeColor = Color.Gray; // Reset to placeholder style
            }

        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_pass_Enter(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "Password")
            {
                label_login_error.Text = "";

                textBox_pass.Text = "";
                textBox_pass.ForeColor = Color.Black;  // Change to normal text color
                textBox_pass.UseSystemPasswordChar = true; // Hide password characters
            }
        }

        private void textBox_pass_Leave(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "")
            {
                textBox_pass.Text = "Password";
                textBox_pass.ForeColor = Color.Gray;  // Reset to placeholder style
                textBox_pass.UseSystemPasswordChar = false; // Show password characters
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}