namespace FilmCrave
{
    partial class Login
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_Header = new System.Windows.Forms.GroupBox();
            this.grb_Login = new System.Windows.Forms.GroupBox();
            this.lblLink_Register = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_Header.SuspendLayout();
            this.grb_Login.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Header
            // 
            this.grb_Header.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grb_Header.Controls.Add(this.pictureBox2);
            this.grb_Header.Controls.Add(this.pictureBox1);
            this.grb_Header.Location = new System.Drawing.Point(24, 38);
            this.grb_Header.Name = "grb_Header";
            this.grb_Header.Size = new System.Drawing.Size(799, 124);
            this.grb_Header.TabIndex = 2;
            this.grb_Header.TabStop = false;
            // 
            // grb_Login
            // 
            this.grb_Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grb_Login.Controls.Add(this.lblLink_Register);
            this.grb_Login.Controls.Add(this.btn_login);
            this.grb_Login.Controls.Add(this.txtPassword);
            this.grb_Login.Controls.Add(this.txt_Username);
            this.grb_Login.Controls.Add(this.lbl_password);
            this.grb_Login.Controls.Add(this.lbl_Username);
            this.grb_Login.Location = new System.Drawing.Point(228, 217);
            this.grb_Login.Name = "grb_Login";
            this.grb_Login.Size = new System.Drawing.Size(366, 140);
            this.grb_Login.TabIndex = 3;
            this.grb_Login.TabStop = false;
            // 
            // lblLink_Register
            // 
            this.lblLink_Register.AutoSize = true;
            this.lblLink_Register.Location = new System.Drawing.Point(25, 104);
            this.lblLink_Register.Name = "lblLink_Register";
            this.lblLink_Register.Size = new System.Drawing.Size(46, 13);
            this.lblLink_Register.TabIndex = 4;
            this.lblLink_Register.TabStop = true;
            this.lblLink_Register.Text = "Register";
            this.lblLink_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_Register_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(260, 97);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 27);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(111, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(111, 17);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(150, 20);
            this.txt_Username.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(25, 61);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(25, 20);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FilmCrave.Properties.Resources.name;
            this.pictureBox2.Location = new System.Drawing.Point(25, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 73);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FilmCrave.Properties.Resources.reel;
            this.pictureBox1.Location = new System.Drawing.Point(474, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(852, 525);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grb_Login);
            this.Controls.Add(this.grb_Header);
            this.Name = "Login";
            this.Text = " ";
            this.grb_Header.ResumeLayout(false);
            this.grb_Login.ResumeLayout(false);
            this.grb_Login.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grb_Header;
        private System.Windows.Forms.GroupBox grb_Login;
        private System.Windows.Forms.LinkLabel lblLink_Register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

