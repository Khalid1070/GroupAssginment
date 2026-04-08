namespace GroupAssginment
{
    partial class Student
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxCourses = new System.Windows.Forms.GroupBox();
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.lblCourse2 = new System.Windows.Forms.Label();
            this.lblCourse3 = new System.Windows.Forms.Label();
            this.lblCourse4 = new System.Windows.Forms.Label();
            this.lblCourse5 = new System.Windows.Forms.Label();
            this.cmbGrade1 = new System.Windows.Forms.ComboBox();
            this.cmbGrade2 = new System.Windows.Forms.ComboBox();
            this.cmbGrade3 = new System.Windows.Forms.ComboBox();
            this.cmbGrade4 = new System.Windows.Forms.ComboBox();
            this.cmbGrade5 = new System.Windows.Forms.ComboBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnSaveGrades = new System.Windows.Forms.Button();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.btnCalculateGPA = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.lblGradesDisplay = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBoxCourses.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToLoginToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // returnToLoginToolStripMenuItem
            // 
            this.returnToLoginToolStripMenuItem.Name = "returnToLoginToolStripMenuItem";
            this.returnToLoginToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.returnToLoginToolStripMenuItem.Text = "Return to Login";
            this.returnToLoginToolStripMenuItem.Click += new System.EventHandler(this.returnToLoginToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.panelTop.Controls.Add(this.lblSubTitle);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Location = new System.Drawing.Point(0, 28);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 90);
            this.panelTop.TabIndex = 1;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubTitle.Location = new System.Drawing.Point(26, 50);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(221, 23);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Select grades and manage GPA";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Form";
            // 
            // groupBoxCourses
            // 
            this.groupBoxCourses.BackColor = System.Drawing.Color.White;
            this.groupBoxCourses.Controls.Add(this.lblCourse1);
            this.groupBoxCourses.Controls.Add(this.lblCourse2);
            this.groupBoxCourses.Controls.Add(this.lblCourse3);
            this.groupBoxCourses.Controls.Add(this.lblCourse4);
            this.groupBoxCourses.Controls.Add(this.lblCourse5);
            this.groupBoxCourses.Controls.Add(this.cmbGrade1);
            this.groupBoxCourses.Controls.Add(this.cmbGrade2);
            this.groupBoxCourses.Controls.Add(this.cmbGrade3);
            this.groupBoxCourses.Controls.Add(this.cmbGrade4);
            this.groupBoxCourses.Controls.Add(this.cmbGrade5);
            this.groupBoxCourses.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxCourses.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.groupBoxCourses.Location = new System.Drawing.Point(24, 138);
            this.groupBoxCourses.Name = "groupBoxCourses";
            this.groupBoxCourses.Size = new System.Drawing.Size(390, 255);
            this.groupBoxCourses.TabIndex = 2;
            this.groupBoxCourses.TabStop = false;
            this.groupBoxCourses.Text = "Course Grades";
            // 
            // lblCourse1
            // 
            this.lblCourse1.AutoSize = true;
            this.lblCourse1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourse1.Location = new System.Drawing.Point(20, 40);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(70, 23);
            this.lblCourse1.TabIndex = 0;
            this.lblCourse1.Text = "MIS302:";
            // 
            // lblCourse2
            // 
            this.lblCourse2.AutoSize = true;
            this.lblCourse2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourse2.Location = new System.Drawing.Point(20, 80);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(67, 23);
            this.lblCourse2.TabIndex = 2;
            this.lblCourse2.Text = "ICS104:";
            // 
            // lblCourse3
            // 
            this.lblCourse3.AutoSize = true;
            this.lblCourse3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourse3.Location = new System.Drawing.Point(20, 120);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(86, 23);
            this.lblCourse3.TabIndex = 4;
            this.lblCourse3.Text = "MATH101:";
            // 
            // lblCourse4
            // 
            this.lblCourse4.AutoSize = true;
            this.lblCourse4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourse4.Location = new System.Drawing.Point(20, 160);
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(68, 23);
            this.lblCourse4.TabIndex = 6;
            this.lblCourse4.Text = "IAS212:";
            // 
            // lblCourse5
            // 
            this.lblCourse5.AutoSize = true;
            this.lblCourse5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourse5.Location = new System.Drawing.Point(20, 200);
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(72, 23);
            this.lblCourse5.TabIndex = 8;
            this.lblCourse5.Text = "ENG102:";
            // 
            // cmbGrade1
            // 
            this.cmbGrade1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGrade1.FormattingEnabled = true;
            this.cmbGrade1.Location = new System.Drawing.Point(220, 37);
            this.cmbGrade1.Name = "cmbGrade1";
            this.cmbGrade1.Size = new System.Drawing.Size(140, 31);
            this.cmbGrade1.TabIndex = 1;
            this.cmbGrade1.SelectedIndexChanged += new System.EventHandler(this.cmbGrade1_SelectedIndexChanged);
            // 
            // cmbGrade2
            // 
            this.cmbGrade2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGrade2.FormattingEnabled = true;
            this.cmbGrade2.Location = new System.Drawing.Point(220, 77);
            this.cmbGrade2.Name = "cmbGrade2";
            this.cmbGrade2.Size = new System.Drawing.Size(140, 31);
            this.cmbGrade2.TabIndex = 3;
            this.cmbGrade2.SelectedIndexChanged += new System.EventHandler(this.cmbGrade2_SelectedIndexChanged);
            // 
            // cmbGrade3
            // 
            this.cmbGrade3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGrade3.FormattingEnabled = true;
            this.cmbGrade3.Location = new System.Drawing.Point(220, 117);
            this.cmbGrade3.Name = "cmbGrade3";
            this.cmbGrade3.Size = new System.Drawing.Size(140, 31);
            this.cmbGrade3.TabIndex = 5;
            this.cmbGrade3.SelectedIndexChanged += new System.EventHandler(this.cmbGrade3_SelectedIndexChanged);
            // 
            // cmbGrade4
            // 
            this.cmbGrade4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGrade4.FormattingEnabled = true;
            this.cmbGrade4.Location = new System.Drawing.Point(220, 157);
            this.cmbGrade4.Name = "cmbGrade4";
            this.cmbGrade4.Size = new System.Drawing.Size(140, 31);
            this.cmbGrade4.TabIndex = 7;
            this.cmbGrade4.SelectedIndexChanged += new System.EventHandler(this.cmbGrade4_SelectedIndexChanged);
            // 
            // cmbGrade5
            // 
            this.cmbGrade5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGrade5.FormattingEnabled = true;
            this.cmbGrade5.Location = new System.Drawing.Point(220, 197);
            this.cmbGrade5.Name = "cmbGrade5";
            this.cmbGrade5.Size = new System.Drawing.Size(140, 31);
            this.cmbGrade5.TabIndex = 9;
            this.cmbGrade5.SelectedIndexChanged += new System.EventHandler(this.cmbGrade5_SelectedIndexChanged);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.BackColor = System.Drawing.Color.White;
            this.groupBoxActions.Controls.Add(this.btnSaveGrades);
            this.groupBoxActions.Controls.Add(this.btnViewGrades);
            this.groupBoxActions.Controls.Add(this.btnCalculateGPA);
            this.groupBoxActions.Controls.Add(this.btnClear);
            this.groupBoxActions.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxActions.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.groupBoxActions.Location = new System.Drawing.Point(445, 138);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(418, 255);
            this.groupBoxActions.TabIndex = 3;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // btnSaveGrades
            // 
            this.btnSaveGrades.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSaveGrades.FlatAppearance.BorderSize = 0;
            this.btnSaveGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGrades.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveGrades.ForeColor = System.Drawing.Color.White;
            this.btnSaveGrades.Location = new System.Drawing.Point(45, 40);
            this.btnSaveGrades.Name = "btnSaveGrades";
            this.btnSaveGrades.Size = new System.Drawing.Size(325, 40);
            this.btnSaveGrades.TabIndex = 0;
            this.btnSaveGrades.Text = "Save Grades";
            this.btnSaveGrades.UseVisualStyleBackColor = false;
            this.btnSaveGrades.Click += new System.EventHandler(this.btnSaveGrades_Click);
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.BackColor = System.Drawing.Color.FromArgb(14, 165, 233);
            this.btnViewGrades.FlatAppearance.BorderSize = 0;
            this.btnViewGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGrades.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewGrades.ForeColor = System.Drawing.Color.White;
            this.btnViewGrades.Location = new System.Drawing.Point(45, 92);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(325, 40);
            this.btnViewGrades.TabIndex = 1;
            this.btnViewGrades.Text = "View Grades";
            this.btnViewGrades.UseVisualStyleBackColor = false;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // btnCalculateGPA
            // 
            this.btnCalculateGPA.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnCalculateGPA.FlatAppearance.BorderSize = 0;
            this.btnCalculateGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateGPA.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculateGPA.ForeColor = System.Drawing.Color.White;
            this.btnCalculateGPA.Location = new System.Drawing.Point(45, 144);
            this.btnCalculateGPA.Name = "btnCalculateGPA";
            this.btnCalculateGPA.Size = new System.Drawing.Size(325, 40);
            this.btnCalculateGPA.TabIndex = 2;
            this.btnCalculateGPA.Text = "Calculate GPA";
            this.btnCalculateGPA.UseVisualStyleBackColor = false;
            this.btnCalculateGPA.Click += new System.EventHandler(this.btnCalculateGPA_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(45, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(325, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.BackColor = System.Drawing.Color.White;
            this.groupBoxResults.Controls.Add(this.lblGradesDisplay);
            this.groupBoxResults.Controls.Add(this.lblGPA);
            this.groupBoxResults.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxResults.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.groupBoxResults.Location = new System.Drawing.Point(24, 410);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(839, 110);
            this.groupBoxResults.TabIndex = 4;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // lblGradesDisplay
            // 
            this.lblGradesDisplay.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblGradesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGradesDisplay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGradesDisplay.Location = new System.Drawing.Point(24, 30);
            this.lblGradesDisplay.Name = "lblGradesDisplay";
            this.lblGradesDisplay.Size = new System.Drawing.Size(790, 28);
            this.lblGradesDisplay.TabIndex = 0;
            this.lblGradesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGPA
            // 
            this.lblGPA.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGPA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGPA.Location = new System.Drawing.Point(24, 68);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(790, 28);
            this.lblGPA.TabIndex = 1;
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxCourses);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.Student_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBoxCourses.ResumeLayout(false);
            this.groupBoxCourses.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox groupBoxCourses;
        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.Label lblCourse2;
        private System.Windows.Forms.Label lblCourse3;
        private System.Windows.Forms.Label lblCourse4;
        private System.Windows.Forms.Label lblCourse5;
        private System.Windows.Forms.ComboBox cmbGrade1;
        private System.Windows.Forms.ComboBox cmbGrade2;
        private System.Windows.Forms.ComboBox cmbGrade3;
        private System.Windows.Forms.ComboBox cmbGrade4;
        private System.Windows.Forms.ComboBox cmbGrade5;

        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnSaveGrades;
        private System.Windows.Forms.Button btnViewGrades;
        private System.Windows.Forms.Button btnCalculateGPA;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label lblGradesDisplay;
        private System.Windows.Forms.Label lblGPA;
    }
}