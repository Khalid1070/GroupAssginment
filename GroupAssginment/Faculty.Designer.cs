namespace GroupAssginment
{
    partial class Faculty
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStudentResult = new System.Windows.Forms.Label();
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.lblCourse2 = new System.Windows.Forms.Label();
            this.lblCourse3 = new System.Windows.Forms.Label();
            this.lblCourse4 = new System.Windows.Forms.Label();
            this.lblCourse5 = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(141, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Faculty Grade Search Form";
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Location = new System.Drawing.Point(69, 86);
            this.lblEnterID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(92, 13);
            this.lblEnterID.TabIndex = 2;
            this.lblEnterID.Text = "Enter Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(162, 84);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(140, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(322, 81);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(411, 81);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStudentResult
            // 
            this.lblStudentResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentResult.Location = new System.Drawing.Point(71, 130);
            this.lblStudentResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentResult.Name = "lblStudentResult";
            this.lblStudentResult.Size = new System.Drawing.Size(415, 23);
            this.lblStudentResult.TabIndex = 6;
            this.lblStudentResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourse1
            // 
            this.lblCourse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse1.Location = new System.Drawing.Point(71, 169);
            this.lblCourse1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(415, 23);
            this.lblCourse1.TabIndex = 7;
            this.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourse2
            // 
            this.lblCourse2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse2.Location = new System.Drawing.Point(71, 201);
            this.lblCourse2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(415, 23);
            this.lblCourse2.TabIndex = 8;
            this.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourse3
            // 
            this.lblCourse3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse3.Location = new System.Drawing.Point(71, 232);
            this.lblCourse3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(415, 23);
            this.lblCourse3.TabIndex = 9;
            this.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourse4
            // 
            this.lblCourse4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse4.Location = new System.Drawing.Point(71, 264);
            this.lblCourse4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(415, 23);
            this.lblCourse4.TabIndex = 10;
            this.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourse5
            // 
            this.lblCourse5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse5.Location = new System.Drawing.Point(71, 296);
            this.lblCourse5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(415, 23);
            this.lblCourse5.TabIndex = 11;
            this.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGPA
            // 
            this.lblGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblGPA.Location = new System.Drawing.Point(71, 330);
            this.lblGPA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(415, 26);
            this.lblGPA.TabIndex = 12;
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 382);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.lblCourse5);
            this.Controls.Add(this.lblCourse4);
            this.Controls.Add(this.lblCourse3);
            this.Controls.Add(this.lblCourse2);
            this.Controls.Add(this.lblCourse1);
            this.Controls.Add(this.lblStudentResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblEnterID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Faculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty Form";
            this.Load += new System.EventHandler(this.Faculty_Load);
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnterID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStudentResult;
        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.Label lblCourse2;
        private System.Windows.Forms.Label lblCourse3;
        private System.Windows.Forms.Label lblCourse4;
        private System.Windows.Forms.Label lblCourse5;
        private System.Windows.Forms.Label lblGPA;
    }
}