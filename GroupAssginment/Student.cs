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

            // Clear result labels
            ClearResultLabels();
            lblGPA.Text = "";
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

        // Resets all grade badge labels to empty / default style
        private void ClearResultLabels()
        {
            Label[] badges = { lblResGradeVal1, lblResGradeVal2, lblResGradeVal3,
                               lblResGradeVal4, lblResGradeVal5 };
            foreach (Label lbl in badges)
            {
                lbl.Text = "";
                lbl.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
                lbl.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            }
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

            string[] existingLines = new string[0];
            if (File.Exists(fileName))
            {
                existingLines = File.ReadAllLines(fileName);
            }

            bool updated = false;
            StreamWriter outputFile = File.CreateText(fileName);
            for (int i = 0; i < existingLines.Length; i++)
            {
                if (existingLines[i].StartsWith(studentUsername + ","))
                {
                    outputFile.WriteLine(newLine);
                    updated = true;
                }
                else
                {
                    outputFile.WriteLine(existingLines[i]);
                }
            }
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

            // Display each grade in its own styled badge label
            Label[] badges = { lblResGradeVal1, lblResGradeVal2, lblResGradeVal3,
                               lblResGradeVal4, lblResGradeVal5 };
            for (int i = 0; i < grades.Length; i++)
            {
                StyleGradeBadge(badges[i], grades[i]);
            }
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

            lblGPA.Text = "GPA: " + gpa.ToString("F2");

            // Color-code the GPA label
            if (gpa >= 3.5)
            {
                lblGPA.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);   // green - excellent
            }
            else if (gpa >= 2.5)
            {
                lblGPA.ForeColor = System.Drawing.Color.FromArgb(14, 165, 233);  // blue - good
            }
            else if (gpa >= 1.5)
            {
                lblGPA.ForeColor = System.Drawing.Color.FromArgb(202, 138, 4);   // amber - average
            }
            else
            {
                lblGPA.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);   // red - poor
            }
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
            ClearResultLabels();
            lblGPA.Text = "";
            lblGPA.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
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

        private void cmbGrade5_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbGrade2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbGrade4_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbGrade3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbGrade1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}