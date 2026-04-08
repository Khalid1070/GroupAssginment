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

        // -------------------------------------------------------
        // Styles a grade badge label with a color based on grade
        // -------------------------------------------------------
        private void StyleGradeBadge(Label lbl, string grade)
        {
            lbl.Text = grade;
            switch (grade)
            {
                case "A":
                    lbl.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);   // green
                    lbl.ForeColor = System.Drawing.Color.White;
                    break;
                case "B":
                    lbl.BackColor = System.Drawing.Color.FromArgb(14, 165, 233);  // sky blue
                    lbl.ForeColor = System.Drawing.Color.White;
                    break;
                case "C":
                    lbl.BackColor = System.Drawing.Color.FromArgb(202, 138, 4);   // amber
                    lbl.ForeColor = System.Drawing.Color.White;
                    break;
                case "D":
                    lbl.BackColor = System.Drawing.Color.FromArgb(249, 115, 22);  // orange
                    lbl.ForeColor = System.Drawing.Color.White;
                    break;
                case "F":
                    lbl.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);   // red
                    lbl.ForeColor = System.Drawing.Color.White;
                    break;
                default:
                    lbl.BackColor = System.Drawing.Color.FromArgb(226, 232, 240); // gray
                    lbl.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
                    break;
            }
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
                return;

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
                    return i;
            }
            return -1;
        }

        private void DisplayStudent(int row)
        {
            // Header: student name in blue
            lblStudentResult.Text = "Student: " + studentIds[row];

            // Grade badges - each colored by grade
            Label[] badges = { lblCourse1, lblCourse2, lblCourse3, lblCourse4, lblCourse5 };
            for (int i = 0; i < 5; i++)
            {
                StyleGradeBadge(badges[i], studentGrades[row, i]);
            }

            // GPA with color coding
            double gpa;
            double.TryParse(studentGPAs[row], out gpa);
            lblGPA.Text = "GPA: " + studentGPAs[row];

            if (gpa >= 3.5)
                lblGPA.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);    // green
            else if (gpa >= 2.5)
                lblGPA.ForeColor = System.Drawing.Color.FromArgb(14, 165, 233);   // blue
            else if (gpa >= 1.5)
                lblGPA.ForeColor = System.Drawing.Color.FromArgb(202, 138, 4);    // amber
            else
                lblGPA.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);    // red
        }

        private void ClearOutput()
        {
            lblStudentResult.Text = "";

            Label[] badges = { lblCourse1, lblCourse2, lblCourse3, lblCourse4, lblCourse5 };
            foreach (Label lbl in badges)
            {
                lbl.Text = "";
                lbl.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
                lbl.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            }

            lblGPA.Text = "";
            lblGPA.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
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

        private void lblEnterID_Click(object sender, EventArgs e) { }
        private void lblGPA_Click(object sender, EventArgs e) { }
        private void lblCourse5_Click(object sender, EventArgs e) { }
        private void lblCourse4_Click(object sender, EventArgs e) { }
        private void lblCourse3_Click(object sender, EventArgs e) { }
        private void lblCourse2_Click(object sender, EventArgs e) { }
        private void lblCourse1_Click(object sender, EventArgs e) { }
        private void lblStudentResult_Click(object sender, EventArgs e) { }
        private void txtStudentID_TextChanged(object sender, EventArgs e) { }
    }
}