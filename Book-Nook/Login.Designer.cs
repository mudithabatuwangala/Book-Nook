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
            this.applicationLogo = new System.Windows.Forms.PictureBox();
            this.applicationName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.applicationLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // applicationLogo
            // 
            this.applicationLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.applicationLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.applicationLogo.Image = ((System.Drawing.Image)(resources.GetObject("applicationLogo.Image")));
            this.applicationLogo.Location = new System.Drawing.Point(156, 68);
            this.applicationLogo.Name = "applicationLogo";
            this.applicationLogo.Size = new System.Drawing.Size(50, 50);
            this.applicationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.applicationLogo.TabIndex = 3;
            this.applicationLogo.TabStop = false;
            // 
            // applicationName
            // 
            this.applicationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.applicationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applicationName.Cursor = System.Windows.Forms.Cursors.Default;
            this.applicationName.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.applicationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(58)))), ((int)(((byte)(53)))));
            this.applicationName.Location = new System.Drawing.Point(80, 133);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(217, 26);
            this.applicationName.TabIndex = 9;
            this.applicationName.Text = "Log in to Book Nook";
            this.applicationName.TextChanged += new System.EventHandler(this.applicationName_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.applicationName);
            this.Controls.Add(this.applicationLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.applicationLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox applicationLogo;
        private System.Windows.Forms.TextBox applicationName;
    }
}