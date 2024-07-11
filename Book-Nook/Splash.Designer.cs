namespace Book_Nook
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.splashImage = new System.Windows.Forms.PictureBox();
            this.applicationLogo = new System.Windows.Forms.PictureBox();
            this.copyright = new System.Windows.Forms.TextBox();
            this.splashDescription = new System.Windows.Forms.TextBox();
            this.applicationName = new System.Windows.Forms.TextBox();
            this.applicationSslogan = new System.Windows.Forms.TextBox();
            this.nameLogo = new System.Windows.Forms.PictureBox();
            this.release = new System.Windows.Forms.TextBox();
            this.loading = new System.Windows.Forms.TextBox();
            this.loadingCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // splashImage
            // 
            this.splashImage.Image = ((System.Drawing.Image)(resources.GetObject("splashImage.Image")));
            this.splashImage.Location = new System.Drawing.Point(248, -2);
            this.splashImage.Name = "splashImage";
            this.splashImage.Size = new System.Drawing.Size(354, 403);
            this.splashImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splashImage.TabIndex = 1;
            this.splashImage.TabStop = false;
            // 
            // applicationLogo
            // 
            this.applicationLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.applicationLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.applicationLogo.Image = ((System.Drawing.Image)(resources.GetObject("applicationLogo.Image")));
            this.applicationLogo.Location = new System.Drawing.Point(12, 12);
            this.applicationLogo.Name = "applicationLogo";
            this.applicationLogo.Size = new System.Drawing.Size(50, 50);
            this.applicationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.applicationLogo.TabIndex = 2;
            this.applicationLogo.TabStop = false;
            // 
            // copyright
            // 
            this.copyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.copyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copyright.Cursor = System.Windows.Forms.Cursors.Default;
            this.copyright.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.copyright.Location = new System.Drawing.Point(12, 184);
            this.copyright.Multiline = true;
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(168, 29);
            this.copyright.TabIndex = 7;
            this.copyright.Text = "© 2024 Muditha Batuwangala\r\nAll right reserved";
            // 
            // splashDescription
            // 
            this.splashDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.splashDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.splashDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.splashDescription.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(58)))), ((int)(((byte)(53)))));
            this.splashDescription.Location = new System.Drawing.Point(12, 238);
            this.splashDescription.Multiline = true;
            this.splashDescription.Name = "splashDescription";
            this.splashDescription.Size = new System.Drawing.Size(213, 125);
            this.splashDescription.TabIndex = 6;
            this.splashDescription.Text = resources.GetString("splashDescription.Text");
            // 
            // applicationName
            // 
            this.applicationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.applicationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applicationName.Cursor = System.Windows.Forms.Cursors.Default;
            this.applicationName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.applicationName.Location = new System.Drawing.Point(12, 61);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(144, 29);
            this.applicationName.TabIndex = 8;
            this.applicationName.Text = "Book Nook";
            // 
            // applicationSslogan
            // 
            this.applicationSslogan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.applicationSslogan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applicationSslogan.Cursor = System.Windows.Forms.Cursors.Default;
            this.applicationSslogan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationSslogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(24)))), ((int)(((byte)(95)))));
            this.applicationSslogan.Location = new System.Drawing.Point(14, 94);
            this.applicationSslogan.Name = "applicationSslogan";
            this.applicationSslogan.Size = new System.Drawing.Size(144, 14);
            this.applicationSslogan.TabIndex = 9;
            this.applicationSslogan.Text = "Unlock a Universe";
            // 
            // nameLogo
            // 
            this.nameLogo.Image = ((System.Drawing.Image)(resources.GetObject("nameLogo.Image")));
            this.nameLogo.Location = new System.Drawing.Point(12, 369);
            this.nameLogo.Name = "nameLogo";
            this.nameLogo.Size = new System.Drawing.Size(20, 20);
            this.nameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nameLogo.TabIndex = 10;
            this.nameLogo.TabStop = false;
            // 
            // release
            // 
            this.release.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.release.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.release.Cursor = System.Windows.Forms.Cursors.Default;
            this.release.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.release.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.release.Location = new System.Drawing.Point(12, 167);
            this.release.Name = "release";
            this.release.Size = new System.Drawing.Size(144, 11);
            this.release.TabIndex = 11;
            this.release.Text = "2024 Release";
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.loading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loading.Cursor = System.Windows.Forms.Cursors.Default;
            this.loading.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.loading.Location = new System.Drawing.Point(12, 218);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(94, 10);
            this.loading.TabIndex = 12;
            this.loading.Text = "Loading application... ";
            // 
            // loadingCount
            // 
            this.loadingCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.loadingCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loadingCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadingCount.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.loadingCount.Location = new System.Drawing.Point(101, 218);
            this.loadingCount.Name = "loadingCount";
            this.loadingCount.Size = new System.Drawing.Size(33, 10);
            this.loadingCount.TabIndex = 13;
            this.loadingCount.Text = "100%";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.loadingCount);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.release);
            this.Controls.Add(this.nameLogo);
            this.Controls.Add(this.applicationSslogan);
            this.Controls.Add(this.applicationName);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.splashDescription);
            this.Controls.Add(this.applicationLogo);
            this.Controls.Add(this.splashImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.splashImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox splashImage;
        private System.Windows.Forms.PictureBox applicationLogo;
        private System.Windows.Forms.TextBox copyright;
        private System.Windows.Forms.TextBox splashDescription;
        private System.Windows.Forms.TextBox applicationName;
        private System.Windows.Forms.TextBox applicationSslogan;
        private System.Windows.Forms.PictureBox nameLogo;
        private System.Windows.Forms.TextBox release;
        private System.Windows.Forms.TextBox loading;
        private System.Windows.Forms.TextBox loadingCount;
    }
}

