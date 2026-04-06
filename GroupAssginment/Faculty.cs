using System;
using System.Windows.Forms;

namespace GroupAssginment
{
    public partial class Faculty : Form
    {
        // 1D array for course names
        private string[] courseNames = { "MIS302", "ICS104", "MATH101", "IAS212", "ENG102" };

        // 1D array for student IDs
        private string[] studentIds = { "20210001", "20210002", "20210003" };

        // 2D array for grades of multiple students in multiple courses
        private string[,] studentGrades =
        {
            { "A", "B", "C", "A", "B" },
            { "B", "C", "B", "B", "A" },
            { "A", "A", "B", "A", "A" }
        };

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
            int studentIndex;

            if (searchId == "")
            {
                MessageBox.Show("Please enter a student ID.");
                txtStudentID.Focus();
            }
            else
            {
                studentIndex = FindStudent(searchId);

                if (studentIndex == -1)
                {
                    MessageBox.Show("Student ID not found.");
                    ClearOutput();
                    txtStudentID.Focus();
                }
                else
                {
                    DisplayStudentData(studentIndex);
                }
            }
        }

        private int FindStudent(string id)
        {
            for (int i = 0; i < studentIds.Length; i++)
            {
                if (studentIds[i] == id)
                {
                    return i;
                }
            }

            return -1;
        }

        private void DisplayStudentData(int row)
        {
            lblStudentResult.Text = "Student ID: " + studentIds[row];

            lblCourse1.Text = courseNames[0] + ": " + studentGrades[row, 0];
            lblCourse2.Text = courseNames[1] + ": " + studentGrades[row, 1];
            lblCourse3.Text = courseNames[2] + ": " + studentGrades[row, 2];
            lblCourse4.Text = courseNames[3] + ": " + studentGrades[row, 3];
            lblCourse5.Text = courseNames[4] + ": " + studentGrades[row, 4];

            lblGPA.Text = "GPA: " + CalculateGPA(row).ToString("F2");
        }

        private double CalculateGPA(int row)
        {
            double totalPoints = 0;

            for (int col = 0; col < studentGrades.GetLength(1); col++)
            {
                totalPoints += GetGradePoints(studentGrades[row, col]);
            }

            return totalPoints / studentGrades.GetLength(1);
        }

        private int GetGradePoints(string grade)
        {
            if (grade == "A")
            {
                return 4;
            }
            else if (grade == "B")
            {
                return 3;
            }
            else if (grade == "C")
            {
                return 2;
            }
            else if (grade == "D")
            {
                return 1;
            }
            else
            {
                return 0;
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
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Team Members:\nYour Name - Your ID\nMember 2 - ID\nMember 3 - ID",
                            "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}