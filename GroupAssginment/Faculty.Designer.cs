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
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
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
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterID.Location = new System.Drawing.Point(27, 45);
            this.lblEnterID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(127, 16);
            this.lblEnterID.TabIndex = 2;
            this.lblEnterID.Text = "Enter Student Name:";
            this.lblEnterID.Click += new System.EventHandler(this.lblEnterID_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(158, 42);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(140, 23);
            this.txtStudentID.TabIndex = 3;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(309, 41);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(309, 69);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
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
            this.lblStudentResult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentResult.Location = new System.Drawing.Point(30, 91);
            this.lblStudentResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentResult.Name = "lblStudentResult";
            this.lblStudentResult.Size = new System.Drawing.Size(268, 24);
            this.lblStudentResult.TabIndex = 6;
            this.lblStudentResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStudentResult.Click += new System.EventHandler(this.lblStudentResult_Click);
            // 
            // lblCourse1
            // 
            this.lblCourse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse1.Location = new System.Drawing.Point(31, 130);
            this.lblCourse1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(267, 24);
            this.lblCourse1.TabIndex = 7;
            this.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCourse1.Click += new System.EventHandler(this.lblCourse1_Click);
            // 
            // lblCourse2
            // 
            this.lblCourse2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse2.Location = new System.Drawing.Point(31, 162);
            this.lblCourse2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(267, 24);
            this.lblCourse2.TabIndex = 8;
            this.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCourse2.Click += new System.EventHandler(this.lblCourse2_Click);
            // 
            // lblCourse3
            // 
            this.lblCourse3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse3.Location = new System.Drawing.Point(31, 193);
            this.lblCourse3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(267, 24);
            this.lblCourse3.TabIndex = 9;
            this.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCourse3.Click += new System.EventHandler(this.lblCourse3_Click);
            // 
            // lblCourse4
            // 
            this.lblCourse4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse4.Location = new System.Drawing.Point(31, 225);
            this.lblCourse4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(267, 24);
            this.lblCourse4.TabIndex = 10;
            this.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCourse4.Click += new System.EventHandler(this.lblCourse4_Click);
            // 
            // lblCourse5
            // 
            this.lblCourse5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCourse5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse5.Location = new System.Drawing.Point(31, 257);
            this.lblCourse5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(267, 24);
            this.lblCourse5.TabIndex = 11;
            this.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCourse5.Click += new System.EventHandler(this.lblCourse5_Click);
            // 
            // lblGPA
            // 
            this.lblGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGPA.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(31, 291);
            this.lblGPA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(267, 27);
            this.lblGPA.TabIndex = 12;
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGPA.Click += new System.EventHandler(this.lblGPA_Click);
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 333);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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