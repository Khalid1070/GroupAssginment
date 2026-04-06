using System;
using System.Windows.Forms;

namespace GroupAssginment
{
    public partial class Student : Form
    {
        // 1D array for course names
        private string[] courseNames = { "MIS302", "ICS104", "MATH101", "IAS212", "ENG102" };

        // 1D array to store grades for this student
        private string[] grades = new string[5];

        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            // Add grade options to all combo boxes
            string[] gradeOptions = { "A", "B", "C", "D", "F" };

            cmbGrade1.Items.AddRange(gradeOptions);
            cmbGrade2.Items.AddRange(gradeOptions);
            cmbGrade3.Items.AddRange(gradeOptions);
            cmbGrade4.Items.AddRange(gradeOptions);
            cmbGrade5.Items.AddRange(gradeOptions);

            // Clear display labels
            lblGradesDisplay.Text = "";
            lblGPA.Text = "";
        }

        private void btnSaveGrades_Click(object sender, EventArgs e)
        {
            // Check if all grades are selected
            if (cmbGrade1.SelectedIndex == -1 || cmbGrade2.SelectedIndex == -1 ||
                cmbGrade3.SelectedIndex == -1 || cmbGrade4.SelectedIndex == -1 ||
                cmbGrade5.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a grade for all courses.");
                return;
            }

            // Save grades into the 1D array
            grades[0] = cmbGrade1.SelectedItem.ToString();
            grades[1] = cmbGrade2.SelectedItem.ToString();
            grades[2] = cmbGrade3.SelectedItem.ToString();
            grades[3] = cmbGrade4.SelectedItem.ToString();
            grades[4] = cmbGrade5.SelectedItem.ToString();

            MessageBox.Show("Grades saved successfully!");
        }

        private void btnViewGrades_Click(object sender, EventArgs e)
        {
            // Check if grades have been saved
            if (grades[0] == null)
            {
                MessageBox.Show("No grades saved yet. Please enter and save grades first.");
                return;
            }

            // Display grades using the 1D arrays
            string display = "";
            for (int i = 0; i < courseNames.Length; i++)
            {
                display += courseNames[i] + ": " + grades[i] + "   ";
            }

            lblGradesDisplay.Text = display;
        }

        private void btnCalculateGPA_Click(object sender, EventArgs e)
        {
            // Check if grades have been saved
            if (grades[0] == null)
            {
                MessageBox.Show("No grades saved yet. Please enter and save grades first.");
                return;
            }

            double totalPoints = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                totalPoints += GetGradePoints(grades[i]);
            }

            double gpa = totalPoints / grades.Length;
            lblGPA.Text = "Your GPA: " + gpa.ToString("F2");
        }

        private int GetGradePoints(string grade)
        {
            if (grade == "A")
                return 4;
            else if (grade == "B")
                return 3;
            else if (grade == "C")
                return 2;
            else if (grade == "D")
                return 1;
            else
                return 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbGrade1.SelectedIndex = -1;
            cmbGrade2.SelectedIndex = -1;
            cmbGrade3.SelectedIndex = -1;
            cmbGrade4.SelectedIndex = -1;
            cmbGrade5.SelectedIndex = -1;

            lblGradesDisplay.Text = "";
            lblGPA.Text = "";
        }

        // MenuStrip event handlers
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
