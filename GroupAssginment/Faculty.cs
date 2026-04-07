using System;
using System.IO;
using System.Windows.Forms;

namespace GroupAssginment
{
    public partial class Faculty : Form
    {
        private string[] courseNames = { "MIS302", "ICS104", "MATH101", "IAS212", "ENG102" };

        public Faculty()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            ClearOutput();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtStudentID.Text.Trim();

            if (searchId == "")
            {
                MessageBox.Show("Please enter a student name.");
                txtStudentID.Focus();
                return;
            }

            string fileName = "Students info.txt";

            if (!File.Exists(fileName))
            {
                MessageBox.Show("No student records found. Students need to enter grades first.");
                return;
            }

            // Search for the student in the file
            bool found = false;
            StreamReader inputFile = File.OpenText(fileName);

            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();
                string[] parts = line.Split(',');

                // Format: username,grade1,grade2,grade3,grade4,grade5,GPA
                if (parts.Length == 7 && parts[0] == searchId)
                {
                    found = true;

                    // Display student info
                    lblStudentResult.Text = "Student: " + parts[0];
                    lblCourse1.Text = courseNames[0] + ": " + parts[1];
                    lblCourse2.Text = courseNames[1] + ": " + parts[2];
                    lblCourse3.Text = courseNames[2] + ": " + parts[3];
                    lblCourse4.Text = courseNames[3] + ": " + parts[4];
                    lblCourse5.Text = courseNames[4] + ": " + parts[5];
                    lblGPA.Text = "GPA: " + parts[6];

                    break;
                }
            }

            inputFile.Close();

            if (!found)
            {
                MessageBox.Show("Student not found.");
                ClearOutput();
                txtStudentID.Focus();
            }
        }

        private void ClearOutput()
        {
            lblStudentResult.Text = "";
            lblCourse1.Text = "";
            lblCourse2.Text = "";
            lblCourse3.Text = "";
            lblCourse4.Text = "";
            lblCourse5.Text = "";
            lblGPA.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            ClearOutput();
            txtStudentID.Focus();
        }

        private void returnToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Team Members:\nMuneeb Al Talaq - 202367270\nAnas Bendania  - 202467940\nKhalid Alghamdi - 202185210",
                            "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEnterID_Click(object sender, EventArgs e)
        {

        }

        private void lblGPA_Click(object sender, EventArgs e)
        {

        }

        private void lblCourse5_Click(object sender, EventArgs e)
        {

        }

        private void lblCourse4_Click(object sender, EventArgs e)
        {

        }

        private void lblCourse3_Click(object sender, EventArgs e)
        {

        }

        private void lblCourse2_Click(object sender, EventArgs e)
        {

        }

        private void lblCourse1_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentResult_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
