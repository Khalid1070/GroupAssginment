namespace GroupAssginment
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnSaveGrades = new System.Windows.Forms.Button();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.btnCalculateGPA = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblGradesDisplay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToLoginToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // returnToLoginToolStripMenuItem
            // 
            this.returnToLoginToolStripMenuItem.Name = "returnToLoginToolStripMenuItem";
            this.returnToLoginToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.returnToLoginToolStripMenuItem.Text = "Return to Login";
            this.returnToLoginToolStripMenuItem.Click += new System.EventHandler(this.returnToLoginToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblCourse1
            // 
            this.lblCourse1.AutoSize = true;
            this.lblCourse1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse1.Location = new System.Drawing.Point(6, 36);
            this.lblCourse1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(55, 16);
            this.lblCourse1.TabIndex = 2;
            this.lblCourse1.Text = "MIS302:";
            // 
            // lblCourse2
            // 
            this.lblCourse2.AutoSize = true;
            this.lblCourse2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse2.Location = new System.Drawing.Point(6, 69);
            this.lblCourse2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(53, 16);
            this.lblCourse2.TabIndex = 3;
            this.lblCourse2.Text = "ICS104:";
            // 
            // lblCourse3
            // 
            this.lblCourse3.AutoSize = true;
            this.lblCourse3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse3.Location = new System.Drawing.Point(6, 101);
            this.lblCourse3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(67, 16);
            this.lblCourse3.TabIndex = 4;
            this.lblCourse3.Text = "MATH101:";
            // 
            // lblCourse4
            // 
            this.lblCourse4.AutoSize = true;
            this.lblCourse4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse4.Location = new System.Drawing.Point(6, 134);
            this.lblCourse4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(53, 16);
            this.lblCourse4.TabIndex = 5;
            this.lblCourse4.Text = "IAS212:";
            // 
            // lblCourse5
            // 
            this.lblCourse5.AutoSize = true;
            this.lblCourse5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse5.Location = new System.Drawing.Point(6, 166);
            this.lblCourse5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(56, 16);
            this.lblCourse5.TabIndex = 6;
            this.lblCourse5.Text = "ENG102:";
            // 
            // cmbGrade1
            // 
            this.cmbGrade1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbGrade1.FormattingEnabled = true;
            this.cmbGrade1.Location = new System.Drawing.Point(80, 34);
            this.cmbGrade1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrade1.Name = "cmbGrade1";
            this.cmbGrade1.Size = new System.Drawing.Size(76, 24);
            this.cmbGrade1.TabIndex = 7;
            this.cmbGrade1.SelectedIndexChanged += new System.EventHandler(this.cmbGrade1_SelectedIndexChanged);
            // 
            // cmbGrade2
            // 
            this.cmbGrade2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbGrade2.FormattingEnabled = true;
            this.cmbGrade2.Location = new System.Drawing.Point(80, 66);
            this.cmbGrade2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrade2.Name = "cmbGrade2";
            this.cmbGrade2.Size = new System.Drawing.Size(76, 24);
            this.cmbGrade2.TabIndex = 8;
            this.cmbGrade2.SelectedIndexChanged += new System.EventHandler(this.cmbGrade2_SelectedIndexChanged);
            // 
            // cmbGrade3
            // 
            this.cmbGrade3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbGrade3.FormattingEnabled = true;
            this.cmbGrade3.Location = new System.Drawing.Point(80, 99);
            this.cmbGrade3.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrade3.Name = "cmbGrade3";
            this.cmbGrade3.Size = new System.Drawing.Size(76, 24);
            this.cmbGrade3.TabIndex = 9;
            this.cmbGrade3.SelectedIndexChanged += new System.EventHandler(this.cmbGrade3_SelectedIndexChanged);
            // 
            // cmbGrade4
            // 
            this.cmbGrade4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbGrade4.FormattingEnabled = true;
            this.cmbGrade4.Location = new System.Drawing.Point(80, 131);
            this.cmbGrade4.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrade4.Name = "cmbGrade4";
            this.cmbGrade4.Size = new System.Drawing.Size(76, 24);
            this.cmbGrade4.TabIndex = 10;
            this.cmbGrade4.SelectedIndexChanged += new System.EventHandler(this.cmbGrade4_SelectedIndexChanged);
            // 
            // cmbGrade5
            // 
            this.cmbGrade5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbGrade5.FormattingEnabled = true;
            this.cmbGrade5.Location = new System.Drawing.Point(80, 164);
            this.cmbGrade5.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrade5.Name = "cmbGrade5";
            this.cmbGrade5.Size = new System.Drawing.Size(76, 24);
            this.cmbGrade5.TabIndex = 11;
            this.cmbGrade5.SelectedIndexChanged += new System.EventHandler(this.cmbGrade5_SelectedIndexChanged);
            // 
            // btnSaveGrades
            // 
            this.btnSaveGrades.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGrades.Location = new System.Drawing.Point(230, 36);
            this.btnSaveGrades.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveGrades.Name = "btnSaveGrades";
            this.btnSaveGrades.Size = new System.Drawing.Size(90, 28);
            this.btnSaveGrades.TabIndex = 12;
            this.btnSaveGrades.Text = "Save Grades";
            this.btnSaveGrades.UseVisualStyleBackColor = true;
            this.btnSaveGrades.Click += new System.EventHandler(this.btnSaveGrades_Click);
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGrades.Location = new System.Drawing.Point(230, 79);
            this.btnViewGrades.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(90, 28);
            this.btnViewGrades.TabIndex = 13;
            this.btnViewGrades.Text = "View Grades";
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // btnCalculateGPA
            // 
            this.btnCalculateGPA.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateGPA.Location = new System.Drawing.Point(230, 122);
            this.btnCalculateGPA.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateGPA.Name = "btnCalculateGPA";
            this.btnCalculateGPA.Size = new System.Drawing.Size(98, 28);
            this.btnCalculateGPA.TabIndex = 14;
            this.btnCalculateGPA.Text = "Calculate GPA";
            this.btnCalculateGPA.UseVisualStyleBackColor = true;
            this.btnCalculateGPA.Click += new System.EventHandler(this.btnCalculateGPA_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(230, 164);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblGPA
            // 
            this.lblGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGPA.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(15, 256);
            this.lblGPA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(398, 26);
            this.lblGPA.TabIndex = 17;
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGradesDisplay
            // 
            this.lblGradesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGradesDisplay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradesDisplay.Location = new System.Drawing.Point(15, 214);
            this.lblGradesDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradesDisplay.Name = "lblGradesDisplay";
            this.lblGradesDisplay.Size = new System.Drawing.Size(398, 25);
            this.lblGradesDisplay.TabIndex = 16;
            this.lblGradesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 343);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.lblGradesDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateGPA);
            this.Controls.Add(this.btnViewGrades);
            this.Controls.Add(this.btnSaveGrades);
            this.Controls.Add(this.cmbGrade5);
            this.Controls.Add(this.cmbGrade4);
            this.Controls.Add(this.cmbGrade3);
            this.Controls.Add(this.cmbGrade2);
            this.Controls.Add(this.cmbGrade1);
            this.Controls.Add(this.lblCourse5);
            this.Controls.Add(this.lblCourse4);
            this.Controls.Add(this.lblCourse3);
            this.Controls.Add(this.lblCourse2);
            this.Controls.Add(this.lblCourse1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.Student_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnSaveGrades;
        private System.Windows.Forms.Button btnViewGrades;
        private System.Windows.Forms.Button btnCalculateGPA;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblGradesDisplay;
    }
}
