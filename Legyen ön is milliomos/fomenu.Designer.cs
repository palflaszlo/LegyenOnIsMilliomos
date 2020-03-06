namespace Legyen_ön_is_milliomos
{
    partial class fomenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fomenu));
            this.btnKerdes = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btmStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKerdes
            // 
            this.btnKerdes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKerdes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKerdes.Location = new System.Drawing.Point(12, 298);
            this.btnKerdes.Name = "btnKerdes";
            this.btnKerdes.Size = new System.Drawing.Size(125, 30);
            this.btnKerdes.TabIndex = 13;
            this.btnKerdes.Text = "Kérdés felvétele";
            this.btnKerdes.UseVisualStyleBackColor = true;
            this.btnKerdes.Click += new System.EventHandler(this.btnKerdes_Click);
            // 
            // btnScore
            // 
            this.btnScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnScore.Location = new System.Drawing.Point(13, 373);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(125, 30);
            this.btnScore.TabIndex = 12;
            this.btnScore.Text = "Statisztika";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProfile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProfile.Location = new System.Drawing.Point(13, 337);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(125, 30);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.Text = "Profil";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoad.Location = new System.Drawing.Point(12, 262);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 30);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Korábbi játék betöltése";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btmStart
            // 
            this.btmStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btmStart.BackColor = System.Drawing.SystemColors.Control;
            this.btmStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btmStart.Location = new System.Drawing.Point(13, 226);
            this.btmStart.Name = "btmStart";
            this.btmStart.Size = new System.Drawing.Size(125, 30);
            this.btmStart.TabIndex = 8;
            this.btmStart.Text = "Új játék";
            this.btmStart.UseVisualStyleBackColor = false;
            this.btmStart.Click += new System.EventHandler(this.btmStart_Click);
            // 
            // fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKerdes);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btmStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fomenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legyen ön is milliomos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKerdes;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btmStart;
    }
}

