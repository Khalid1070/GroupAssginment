namespace GroupAssginment
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.linkLabel_SignUp = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // ── menuStrip1 ──────────────────────────────────────────
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.helpToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.Text = "menuStrip1";

            // helpToolStripMenuItem
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.aboutToolStripMenuItem });
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";

            // aboutToolStripMenuItem
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);

            // ── lblTitle ────────────────────────────────────────────
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(118, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 24);
            this.lblTitle.Text = "Login Form";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);

            // ── label1  (Username) ──────────────────────────────────
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);

            // ── textBox_userName ────────────────────────────────────
            this.textBox_userName.Location = new System.Drawing.Point(150, 92);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(160, 20);

            // ── label2  (Password) ──────────────────────────────────
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.Text = "Password";

            // ── textBox_pass ────────────────────────────────────────
            this.textBox_pass.Location = new System.Drawing.Point(150, 132);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(160, 20);

            // ── button_LogIn ────────────────────────────────────────
            this.button_LogIn.Location = new System.Drawing.Point(120, 175);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(75, 23);
            this.button_LogIn.Text = "Login";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);

            // ── button_Exit ─────────────────────────────────────────
            this.button_Exit.Location = new System.Drawing.Point(210, 175);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);

            // ── lblLoginError ───────────────────────────────────────
            this.lblLoginError.AutoSize = false;
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
            this.lblLoginError.Location = new System.Drawing.Point(60, 210);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(264, 18);
            this.lblLoginError.Text = "";
            this.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginError.Visible = false;

            // ── linkLabel_SignUp  (NEW) ─────────────────────────────
            this.linkLabel_SignUp.AutoSize = true;
            this.linkLabel_SignUp.Location = new System.Drawing.Point(103, 238);
            this.linkLabel_SignUp.Name = "linkLabel_SignUp";
            this.linkLabel_SignUp.Size = new System.Drawing.Size(178, 13);
            this.linkLabel_SignUp.Text = "Don't have an account? Sign Up";
            this.linkLabel_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_SignUp_LinkClicked);

            // ── Form1 ───────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.linkLabel_SignUp);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.LinkLabel linkLabel_SignUp;
    }
}