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
            lblLoginError.Text = "";
            lblLoginError.Visible = false;

            usernameTextBox.Text = "Username";
            usernameTextBox.ForeColor = Color.Gray;

            textBox_pass.Text = "Password";
            textBox_pass.ForeColor = Color.Gray;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            // Clear old error message
            lblLoginError.Text = "";
            lblLoginError.Visible = false;

            string username = textBox_userName.Text.Trim();
            string password = textBox_pass.Text.Trim();

            if (username == "" || password == "")
            {
                lblLoginError.Text = "Please enter both username and password.";
                lblLoginError.Visible = true;
                return;
            }

            // Always resolve users.txt from the application's own folder
            string filePath = System.IO.Path.Combine(Application.StartupPath, "users.txt");

            if (!File.Exists(filePath))
            {
                lblLoginError.Text = "No accounts found. Please sign up first.";
                lblLoginError.Visible = true;
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
                        lblLoginError.Text = "";
                        lblLoginError.Visible = false;

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
                lblLoginError.Text = "Invalid username or password.";
                lblLoginError.Visible = true;
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";
                usernameTextBox.ForeColor = Color.Black;
            }
        }

        private void label1_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Trim() == "")
            {
                usernameTextBox.Text = "Username";
                usernameTextBox.ForeColor = Color.Gray;
            }
        }
    }
}