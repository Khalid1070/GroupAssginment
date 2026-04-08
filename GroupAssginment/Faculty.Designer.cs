namespace GroupAssginment
{
    partial class Faculty
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.lblStudentResult = new System.Windows.Forms.Label();
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.lblCourse2 = new System.Windows.Forms.Label();
            this.lblCourse3 = new System.Windows.Forms.Label();
            this.lblCourse4 = new System.Windows.Forms.Label();
            this.lblCourse5 = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(760, 28);
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
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
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
            this.panelTop.Size = new System.Drawing.Size(760, 90);
            this.panelTop.TabIndex = 1;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubTitle.Location = new System.Drawing.Point(26, 50);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(241, 23);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Search and review student grades";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Faculty Form";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.White;
            this.groupBoxSearch.Controls.Add(this.lblEnterID);
            this.groupBoxSearch.Controls.Add(this.txtStudentID);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.btnClear);
            this.groupBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxSearch.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.groupBoxSearch.Location = new System.Drawing.Point(24, 138);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(712, 110);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Student Search";
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEnterID.Location = new System.Drawing.Point(22, 43);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(158, 23);
            this.lblEnterID.TabIndex = 0;
            this.lblEnterID.Text = "Enter Student Name:";
            this.lblEnterID.Click += new System.EventHandler(this.lblEnterID_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentID.Location = new System.Drawing.Point(190, 40);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(220, 30);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(445, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(570, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.White;
            this.groupBoxDetails.Controls.Add(this.lblStudentResult);
            this.groupBoxDetails.Controls.Add(this.lblCourse1);
            this.groupBoxDetails.Controls.Add(this.lblCourse2);
            this.groupBoxDetails.Controls.Add(this.lblCourse3);
            this.groupBoxDetails.Controls.Add(this.lblCourse4);
            this.groupBoxDetails.Controls.Add(this.lblCourse5);
            this.groupBoxDetails.Controls.Add(this.lblGPA);
            this.groupBoxDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxDetails.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.groupBoxDetails.Location = new System.Drawing.Point(24, 265);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(712, 255);
            this.groupBoxDetails.TabIndex = 3;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Student Details";
            // 
            // lblStudentResult
            // 
            this.lblStudentResult.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblStudentResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudentResult.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStudentResult.Location = new System.Drawing.Point(26, 31);
            this.lblStudentResult.Name = "lblStudentResult";
            this.lblStudentResult.Size = new System.Drawing.Size(654, 28);
            this.lblStudentResult.TabIndex = 0;
            this.lblStudentResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStudentResult.Click += new System.EventHandler(this.lblStudentResult_Click);
            // 
            // lblCourse1
            // 
            this.lblCourse1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblCourse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourse1.Location = new System.Drawing.Point(26, 68);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(654, 28);
            this.lblCourse1.TabIndex = 1;
            this.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCourse1.Click += new System.EventHandler(this.lblCourse1_Click);
            // 
            // lblCourse2
            // 
            this.lblCourse2.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblCourse2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourse2.Location = new System.Drawing.Point(26, 101);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(654, 28);
            this.lblCourse2.TabIndex = 2;
            this.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCourse2.Click += new System.EventHandler(this.lblCourse2_Click);
            // 
            // lblCourse3
            // 
            this.lblCourse3.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblCourse3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourse3.Location = new System.Drawing.Point(26, 134);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(654, 28);
            this.lblCourse3.TabIndex = 3;
            this.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCourse3.Click += new System.EventHandler(this.lblCourse3_Click);
            // 
            // lblCourse4
            // 
            this.lblCourse4.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblCourse4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourse4.Location = new System.Drawing.Point(26, 167);
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(654, 28);
            this.lblCourse4.TabIndex = 4;
            this.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCourse4.Click += new System.EventHandler(this.lblCourse4_Click);
            // 
            // lblCourse5
            // 
            this.lblCourse5.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.lblCourse5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCourse5.Location = new System.Drawing.Point(26, 200);
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(654, 28);
            this.lblCourse5.TabIndex = 5;
            this.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCourse5.Click += new System.EventHandler(this.lblCourse5_Click);
            // 
            // lblGPA
            // 
            this.lblGPA.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.lblGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGPA.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblGPA.Location = new System.Drawing.Point(26, 233);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(654, 28);
            this.lblGPA.TabIndex = 6;
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGPA.Click += new System.EventHandler(this.lblGPA_Click);
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(760, 540);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Faculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty Form";
            this.Load += new System.EventHandler(this.Faculty_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
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

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label lblEnterID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label lblStudentResult;
        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.Label lblCourse2;
        private System.Windows.Forms.Label lblCourse3;
        private System.Windows.Forms.Label lblCourse4;
        private System.Windows.Forms.Label lblCourse5;
        private System.Windows.Forms.Label lblGPA;
    }
}