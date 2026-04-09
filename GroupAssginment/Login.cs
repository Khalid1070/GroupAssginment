using System;
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

            if (!File.Exists("users.txt"))
            {
                lblLoginError.Text = "users.txt file not found.";
                lblLoginError.Visible = true;
                return;
            }

            bool found = false;

            StreamReader inputFile = File.OpenText("users.txt");
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


        private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
        }
    }
}