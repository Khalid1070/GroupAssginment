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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblCourseName1 = new System.Windows.Forms.Label();
            this.lblCourseName2 = new System.Windows.Forms.Label();
            this.lblCourseName3 = new System.Windows.Forms.Label();
            this.lblCourseName4 = new System.Windows.Forms.Label();
            this.lblCourseName5 = new System.Windows.Forms.Label();
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.lblCourse2 = new System.Windows.Forms.Label();
            this.lblCourse3 = new System.Windows.Forms.Label();
            this.lblCourse4 = new System.Windows.Forms.Label();
            this.lblCourse5 = new System.Windows.Forms.Label();
            this.panelDetRowSep1 = new System.Windows.Forms.Panel();
            this.panelDetRowSep2 = new System.Windows.Forms.Panel();
            this.panelDetRowSep3 = new System.Windows.Forms.Panel();
            this.panelDetRowSep4 = new System.Windows.Forms.Panel();
            this.panelDetRowSep5 = new System.Windows.Forms.Panel();
            this.panelDetGPASep = new System.Windows.Forms.Panel();
            this.lblGPA = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
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
            this.lblSubTitle.Size = new System.Drawing.Size(267, 23);
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
            this.lblTitle.Size = new System.Drawing.Size(193, 41);
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
            this.groupBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
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
            this.lblEnterID.Location = new System.Drawing.Point(12, 43);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(169, 23);
            this.lblEnterID.TabIndex = 0;
            this.lblEnterID.Text = "Enter Student Name:";
            this.lblEnterID.Click += new System.EventHandler(this.lblEnterID_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStudentID.Location = new System.Drawing.Point(195, 40);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(220, 30);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
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
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
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
            this.groupBoxDetails.Controls.Add(this.lblCourseName1);
            this.groupBoxDetails.Controls.Add(this.lblCourseName2);
            this.groupBoxDetails.Controls.Add(this.lblCourseName3);
            this.groupBoxDetails.Controls.Add(this.lblCourseName4);
            this.groupBoxDetails.Controls.Add(this.lblCourseName5);
            this.groupBoxDetails.Controls.Add(this.lblCourse1);
            this.groupBoxDetails.Controls.Add(this.lblCourse2);
            this.groupBoxDetails.Controls.Add(this.lblCourse3);
            this.groupBoxDetails.Controls.Add(this.lblCourse4);
            this.groupBoxDetails.Controls.Add(this.lblCourse5);
            this.groupBoxDetails.Controls.Add(this.panelDetRowSep1);
            this.groupBoxDetails.Controls.Add(this.panelDetRowSep2);
            this.groupBoxDetails.Controls.Add(this.panelDetRowSep3);
            this.groupBoxDetails.Controls.Add(this.panelDetRowSep4);
            this.groupBoxDetails.Controls.Add(this.panelDetRowSep5);
            this.groupBoxDetails.Controls.Add(this.panelDetGPASep);
            this.groupBoxDetails.Controls.Add(this.lblGPA);
            this.groupBoxDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.groupBoxDetails.Location = new System.Drawing.Point(24, 265);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(712, 295);
            this.groupBoxDetails.TabIndex = 3;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Student Details";
            // 
            // lblStudentResult
            // 
            this.lblStudentResult.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblStudentResult.Location = new System.Drawing.Point(22, 26);
            this.lblStudentResult.Name = "lblStudentResult";
            this.lblStudentResult.Size = new System.Drawing.Size(666, 28);
            this.lblStudentResult.TabIndex = 0;
            this.lblStudentResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStudentResult.Click += new System.EventHandler(this.lblStudentResult_Click);
            // 
            // lblCourseName1
            // 
            this.lblCourseName1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourseName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCourseName1.Location = new System.Drawing.Point(22, 64);
            this.lblCourseName1.Name = "lblCourseName1";
            this.lblCourseName1.Size = new System.Drawing.Size(110, 28);
            this.lblCourseName1.TabIndex = 10;
            this.lblCourseName1.Text = "MIS302:";
            this.lblCourseName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseName2
            // 
            this.lblCourseName2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourseName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCourseName2.Location = new System.Drawing.Point(22, 102);
            this.lblCourseName2.Name = "lblCourseName2";
            this.lblCourseName2.Size = new System.Drawing.Size(110, 28);
            this.lblCourseName2.TabIndex = 11;
            this.lblCourseName2.Text = "ICS104:";
            this.lblCourseName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseName3
            // 
            this.lblCourseName3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourseName3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCourseName3.Location = new System.Drawing.Point(22, 140);
            this.lblCourseName3.Name = "lblCourseName3";
            this.lblCourseName3.Size = new System.Drawing.Size(110, 28);
            this.lblCourseName3.TabIndex = 12;
            this.lblCourseName3.Text = "MATH101:";
            this.lblCourseName3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseName4
            // 
            this.lblCourseName4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourseName4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCourseName4.Location = new System.Drawing.Point(22, 178);
            this.lblCourseName4.Name = "lblCourseName4";
            this.lblCourseName4.Size = new System.Drawing.Size(110, 28);
            this.lblCourseName4.TabIndex = 13;
            this.lblCourseName4.Text = "IAS212:";
            this.lblCourseName4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseName5
            // 
            this.lblCourseName5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourseName5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCourseName5.Location = new System.Drawing.Point(22, 216);
            this.lblCourseName5.Name = "lblCourseName5";
            this.lblCourseName5.Size = new System.Drawing.Size(110, 28);
            this.lblCourseName5.TabIndex = 14;
            this.lblCourseName5.Text = "ENG102:";
            this.lblCourseName5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourse1
            // 
            this.lblCourse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblCourse1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourse1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCourse1.Location = new System.Drawing.Point(627, 64);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(58, 28);
            this.lblCourse1.TabIndex = 1;
            this.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCourse1.Click += new System.EventHandler(this.lblCourse1_Click);
            // 
            // lblCourse2
            // 
            this.lblCourse2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblCourse2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourse2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCourse2.Location = new System.Drawing.Point(627, 102);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(58, 28);
            this.lblCourse2.TabIndex = 2;
            this.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCourse2.Click += new System.EventHandler(this.lblCourse2_Click);
            // 
            // lblCourse3
            // 
            this.lblCourse3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblCourse3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourse3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCourse3.Location = new System.Drawing.Point(627, 140);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(58, 28);
            this.lblCourse3.TabIndex = 3;
            this.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCourse3.Click += new System.EventHandler(this.lblCourse3_Click);
            // 
            // lblCourse4
            // 
            this.lblCourse4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblCourse4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourse4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCourse4.Location = new System.Drawing.Point(627, 178);
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(58, 28);
            this.lblCourse4.TabIndex = 4;
            this.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCourse4.Click += new System.EventHandler(this.lblCourse4_Click);
            // 
            // lblCourse5
            // 
            this.lblCourse5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblCourse5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCourse5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCourse5.Location = new System.Drawing.Point(627, 216);
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(58, 28);
            this.lblCourse5.TabIndex = 5;
            this.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCourse5.Click += new System.EventHandler(this.lblCourse5_Click);
            // 
            // panelDetRowSep1
            // 
            this.panelDetRowSep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panelDetRowSep1.Location = new System.Drawing.Point(22, 58);
            this.panelDetRowSep1.Name = "panelDetRowSep1";
            this.panelDetRowSep1.Size = new System.Drawing.Size(666, 1);
            this.panelDetRowSep1.TabIndex = 20;
            // 
            // panelDetRowSep2
            // 
            this.panelDetRowSep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panelDetRowSep2.Location = new System.Drawing.Point(22, 96);
            this.panelDetRowSep2.Name = "panelDetRowSep2";
            this.panelDetRowSep2.Size = new System.Drawing.Size(666, 1);
            this.panelDetRowSep2.TabIndex = 21;
            // 
            // panelDetRowSep3
            // 
            this.panelDetRowSep3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panelDetRowSep3.Location = new System.Drawing.Point(22, 134);
            this.panelDetRowSep3.Name = "panelDetRowSep3";
            this.panelDetRowSep3.Size = new System.Drawing.Size(666, 1);
            this.panelDetRowSep3.TabIndex = 22;
            // 
            // panelDetRowSep4
            // 
            this.panelDetRowSep4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panelDetRowSep4.Location = new System.Drawing.Point(22, 172);
            this.panelDetRowSep4.Name = "panelDetRowSep4";
            this.panelDetRowSep4.Size = new System.Drawing.Size(666, 1);
            this.panelDetRowSep4.TabIndex = 23;
            // 
            // panelDetRowSep5
            // 
            this.panelDetRowSep5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panelDetRowSep5.Location = new System.Drawing.Point(22, 210);
            this.panelDetRowSep5.Name = "panelDetRowSep5";
            this.panelDetRowSep5.Size = new System.Drawing.Size(666, 1);
            this.panelDetRowSep5.TabIndex = 24;
            // 
            // panelDetGPASep
            // 
            this.panelDetGPASep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.panelDetGPASep.Location = new System.Drawing.Point(22, 253);
            this.panelDetGPASep.Name = "panelDetGPASep";
            this.panelDetGPASep.Size = new System.Drawing.Size(666, 2);
            this.panelDetGPASep.TabIndex = 25;
            // 
            // lblGPA
            // 
            this.lblGPA.BackColor = System.Drawing.Color.Transparent;
            this.lblGPA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblGPA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblGPA.Location = new System.Drawing.Point(22, 259);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(666, 28);
            this.lblGPA.TabIndex = 6;
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGPA.Click += new System.EventHandler(this.lblGPA_Click);
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(760, 580);
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
        // Static course name labels
        private System.Windows.Forms.Label lblCourseName1;
        private System.Windows.Forms.Label lblCourseName2;
        private System.Windows.Forms.Label lblCourseName3;
        private System.Windows.Forms.Label lblCourseName4;
        private System.Windows.Forms.Label lblCourseName5;
        // Grade value labels
        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.Label lblCourse2;
        private System.Windows.Forms.Label lblCourse3;
        private System.Windows.Forms.Label lblCourse4;
        private System.Windows.Forms.Label lblCourse5;
        // Separators
        private System.Windows.Forms.Panel panelDetRowSep1;
        private System.Windows.Forms.Panel panelDetRowSep2;
        private System.Windows.Forms.Panel panelDetRowSep3;
        private System.Windows.Forms.Panel panelDetRowSep4;
        private System.Windows.Forms.Panel panelDetRowSep5;
        private System.Windows.Forms.Panel panelDetGPASep;
        private System.Windows.Forms.Label lblGPA;
    }
}