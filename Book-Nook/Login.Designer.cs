using System.Windows.Forms;

namespace Book_Nook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginLabel = new System.Windows.Forms.TextBox();
            this.applicationLogo = new System.Windows.Forms.PictureBox();
            this.emailUsernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.emailUsernameTxtbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signupLabel = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applicationLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.loginLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.loginLabel.Location = new System.Drawing.Point(440, 123);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(201, 23);
            this.loginLabel.TabIndex = 9;
            this.loginLabel.Text = "Login to Book Nook";
            this.loginLabel.TextChanged += new System.EventHandler(this.applicationName_TextChanged_1);
            // 
            // applicationLogo
            // 
            this.applicationLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.applicationLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.applicationLogo.Image = ((System.Drawing.Image)(resources.GetObject("applicationLogo.Image")));
            this.applicationLogo.Location = new System.Drawing.Point(440, 59);
            this.applicationLogo.Name = "applicationLogo";
            this.applicationLogo.Size = new System.Drawing.Size(50, 50);
            this.applicationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.applicationLogo.TabIndex = 10;
            this.applicationLogo.TabStop = false;
            // 
            // emailUsernameLabel
            // 
            this.emailUsernameLabel.AutoSize = true;
            this.emailUsernameLabel.Font = new System.Drawing.Font("Tahoma", 7F);
            this.emailUsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.emailUsernameLabel.Location = new System.Drawing.Point(438, 179);
            this.emailUsernameLabel.Name = "emailUsernameLabel";
            this.emailUsernameLabel.Size = new System.Drawing.Size(88, 12);
            this.emailUsernameLabel.TabIndex = 13;
            this.emailUsernameLabel.Text = "Email or Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Tahoma", 7F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.passwordLabel.Location = new System.Drawing.Point(438, 247);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(48, 12);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Password";
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Tahoma", 7F);
            this.forgotPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.forgotPasswordLabel.Location = new System.Drawing.Point(618, 310);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(112, 12);
            this.forgotPasswordLabel.TabIndex = 15;
            this.forgotPasswordLabel.Text = "Forgot your password?";
            // 
            // emailUsernameTxtbox
            // 
            this.emailUsernameTxtbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.emailUsernameTxtbox.Location = new System.Drawing.Point(440, 194);
            this.emailUsernameTxtbox.Name = "emailUsernameTxtbox";
            this.emailUsernameTxtbox.Size = new System.Drawing.Size(288, 20);
            this.emailUsernameTxtbox.TabIndex = 17;
            this.emailUsernameTxtbox.Text = "mudithatharuka@gmail.com";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(440, 337);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(288, 37);
            this.loginBtn.TabIndex = 18;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // signupLabel
            // 
            this.signupLabel.AutoSize = true;
            this.signupLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.signupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.signupLabel.Location = new System.Drawing.Point(437, 396);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(139, 13);
            this.signupLabel.TabIndex = 19;
            this.signupLabel.Text = "Don\'t have an account?";
            // 
            // signupBtn
            // 
            this.signupBtn.AutoSize = true;
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.signupBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.signupBtn.Location = new System.Drawing.Point(574, 396);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(49, 13);
            this.signupBtn.TabIndex = 20;
            this.signupBtn.Text = "Sign Up";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.emailUsernameTxtbox);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailUsernameLabel);
            this.Controls.Add(this.applicationLogo);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.applicationLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox loginLabel;
        private System.Windows.Forms.PictureBox applicationLogo;
        private System.Windows.Forms.Label emailUsernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.TextBox emailUsernameTxtbox;
        private System.Windows.Forms.Button loginBtn;
        private PictureBox pictureBox1;
        private Label signupLabel;
        private Label signupBtn;
    }
}