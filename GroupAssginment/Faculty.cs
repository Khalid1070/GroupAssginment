using System;
using System.IO;
using System.Windows.Forms;

namespace GroupAssginment
{
    public partial class Faculty : Form
    {
        // 1D array for course names
        private string[] courseNames = { "MIS302", "ICS104", "MATH101", "IAS212", "ENG102" };

        // 1D array for student IDs / usernames
        private string[] studentIds = new string[100];

        private string[,] studentGrades = new string[100, 5];

        private string[] studentGPAs = new string[100];

        // number of students loaded from file
        private int studentCount = 0;

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
                MessageBox.Show("Please enter a student ID.");
                txtStudentID.Focus();
                return;
            }

            LoadStudentData();

            if (studentCount == 0)
            {
                MessageBox.Show("No student records found.");
                return;
            }

            int foundIndex = FindStudent(searchId);

            if (foundIndex == -1)
            {
                MessageBox.Show("Student not found.");
                ClearOutput();
                txtStudentID.Focus();
            }
            else
            {
                DisplayStudent(foundIndex);
            }
        }

        private void LoadStudentData()
        {
            string fileName = "Students info.txt";
            studentCount = 0;

            if (!File.Exists(fileName))
            {
                return;
            }

            StreamReader inputFile = File.OpenText(fileName);

            while (!inputFile.EndOfStream && studentCount < 100)
            {
                string line = inputFile.ReadLine();
                string[] parts = line.Split(',');

                // Format: username,grade1,grade2,grade3,grade4,grade5,GPA
                if (parts.Length == 7)
                {
                    studentIds[studentCount] = parts[0];
                    studentGrades[studentCount, 0] = parts[1];
                    studentGrades[studentCount, 1] = parts[2];
                    studentGrades[studentCount, 2] = parts[3];
                    studentGrades[studentCount, 3] = parts[4];
                    studentGrades[studentCount, 4] = parts[5];
                    studentGPAs[studentCount] = parts[6];

                    studentCount++;
                }
            }

            inputFile.Close();
        }

        private int FindStudent(string searchId)
        {
            for (int i = 0; i < studentCount; i++)
            {
                if (studentIds[i] == searchId)
                {
                    return i;
                }
            }

            return -1;
        }

        private void DisplayStudent(int row)
        {
            lblStudentResult.Text = "Student: " + studentIds[row];
            lblCourse1.Text = courseNames[0] + ": " + studentGrades[row, 0];
            lblCourse2.Text = courseNames[1] + ": " + studentGrades[row, 1];
            lblCourse3.Text = courseNames[2] + ": " + studentGrades[row, 2];
            lblCourse4.Text = courseNames[3] + ": " + studentGrades[row, 3];
            lblCourse5.Text = courseNames[4] + ": " + studentGrades[row, 4];
            lblGPA.Text = "GPA: " + studentGPAs[row];
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
            MessageBox.Show("Team Members:\nMuneeb Al Talaq - 202367270\nAnas Bendania - 202467940\nKhalid Alghamdi - 202185210",
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