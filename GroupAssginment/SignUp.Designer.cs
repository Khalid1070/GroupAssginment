namespace GroupAssginment
{
    partial class SignUp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.AAA = new System.Windows.Forms.GroupBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSignUpError = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.AAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(194, 60);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 32);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Sign Up";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 123);
            this.panel1.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(0, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 70);
            this.label1.TabIndex = 13;
            this.label1.Text = "Create Your New Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AAA
            // 
            this.AAA.BackColor = System.Drawing.SystemColors.Control;
            this.AAA.Controls.Add(this.button_reset);
            this.AAA.Controls.Add(this.comboBox1);
            this.AAA.Controls.Add(this.lblSignUpError);
            this.AAA.Controls.Add(this.textBox_userName);
            this.AAA.Controls.Add(this.textBox_pass);
            this.AAA.Controls.Add(this.button_LogIn);
            this.AAA.Location = new System.Drawing.Point(57, 249);
            this.AAA.Name = "AAA";
            this.AAA.Size = new System.Drawing.Size(408, 351);
            this.AAA.TabIndex = 14;
            this.AAA.TabStop = false;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_reset.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(80, 265);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(240, 57);
            this.button_reset.TabIndex = 13;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Student ",
            "Faculty "});
            this.comboBox1.Location = new System.Drawing.Point(32, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 27);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // lblSignUpError
            // 
            this.lblSignUpError.ForeColor = System.Drawing.Color.Red;
            this.lblSignUpError.Location = new System.Drawing.Point(-57, 0);
            this.lblSignUpError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUpError.Name = "lblSignUpError";
            this.lblSignUpError.Size = new System.Drawing.Size(535, 26);
            this.lblSignUpError.TabIndex = 12;
            this.lblSignUpError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSignUpError.Visible = false;
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(32, 48);
            this.textBox_userName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(348, 27);
            this.textBox_userName.TabIndex = 6;
            this.textBox_userName.Enter += new System.EventHandler(this.textBox_userName_Enter);
            this.textBox_userName.Leave += new System.EventHandler(this.textBox_userName_Leave);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(32, 94);
            this.textBox_pass.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(348, 27);
            this.textBox_pass.TabIndex = 4;
            this.textBox_pass.Enter += new System.EventHandler(this.textBox_pass_Enter);
            this.textBox_pass.Leave += new System.EventHandler(this.textBox_pass_Leave);
            // 
            // button_LogIn
            // 
            this.button_LogIn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_LogIn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogIn.Location = new System.Drawing.Point(80, 200);
            this.button_LogIn.Margin = new System.Windows.Forms.Padding(4);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(240, 57);
            this.button_LogIn.TabIndex = 3;
            this.button_LogIn.Text = "Sign Up";
            this.button_LogIn.UseVisualStyleBackColor = false;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AAA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AAA.ResumeLayout(false);
            this.AAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox AAA;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Label lblSignUpError;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button_reset;
    }
}