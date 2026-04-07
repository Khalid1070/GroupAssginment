using System;
using System.IO;
using System.Windows.Forms;

namespace GroupAssginment
{
    public partial class Student : Form
    {
        // 1D array for course names
        private string[] courseNames = { "MIS302", "ICS104", "MATH101", "IAS212", "ENG102" };

        // 1D array to store grades for this student
        private string[] grades = new string[5];

        // store the logged-in student username
        private string studentUsername;

        public Student(string username)
        {
            InitializeComponent();
            studentUsername = username;
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

            // Calculate GPA
            double totalPoints = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                totalPoints += GetGradePoints(grades[i]);
            }
            double gpa = totalPoints / grades.Length;

            // Save to "Students info.txt" file
            // Format: username,grade1,grade2,grade3,grade4,grade5,GPA
            SaveToFile(gpa);

            MessageBox.Show("Grades saved successfully!");
        }

        private void SaveToFile(double gpa)
        {
            string fileName = "Students info.txt";
            string newLine = studentUsername + "," +
                             grades[0] + "," + grades[1] + "," +
                             grades[2] + "," + grades[3] + "," +
                             grades[4] + "," + gpa.ToString("F2");

            // Read all existing lines (if file exists)
            string[] existingLines = new string[0];
            if (File.Exists(fileName))
            {
                existingLines = File.ReadAllLines(fileName);
            }

            // Check if this student already has a record and update it
            bool updated = false;
            StreamWriter outputFile = File.CreateText(fileName);

            for (int i = 0; i < existingLines.Length; i++)
            {
                if (existingLines[i].StartsWith(studentUsername + ","))
                {
                    // Replace old record with new one
                    outputFile.WriteLine(newLine);
                    updated = true;
                }
                else
                {
                    // Keep existing record
                    outputFile.WriteLine(existingLines[i]);
                }
            }

            // If student had no previous record, add new line
            if (!updated)
            {
                outputFile.WriteLine(newLine);
            }

            outputFile.Close();
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

        private void cmbGrade5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGrade2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGrade4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGrade3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGrade1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
