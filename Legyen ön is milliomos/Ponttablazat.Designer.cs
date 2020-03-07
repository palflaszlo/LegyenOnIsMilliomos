namespace Legyen_ön_is_milliomos
{
    partial class Ponttablazat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ponttablazat));
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.listScore = new System.Windows.Forms.ListView();
            this.lvlid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvpontod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvlmode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 45);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ha már egy rekord nem kell, ki is törölheted, ha azt kijelölve a törlés gombra ka" +
    "ttintasz.";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Törlés";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "A pontszámod egyenlő a megválaszolt kérdéseid számával.";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "A nevedet a profilnál tudod beállítani.";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ez itt a ponttáblázat.";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(733, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 25);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Vissza";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listScore
            // 
            this.listScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvlid,
            this.lvname,
            this.lvpontod,
            this.lvlmode});
            this.listScore.FullRowSelect = true;
            this.listScore.GridLines = true;
            this.listScore.Location = new System.Drawing.Point(308, 12);
            this.listScore.Name = "listScore";
            this.listScore.Size = new System.Drawing.Size(360, 416);
            this.listScore.TabIndex = 7;
            this.listScore.UseCompatibleStateImageBehavior = false;
            this.listScore.View = System.Windows.Forms.View.Details;
            // 
            // lvlid
            // 
            this.lvlid.Text = "ID";
            this.lvlid.Width = 49;
            // 
            // lvname
            // 
            this.lvname.Text = "Neved";
            this.lvname.Width = 110;
            // 
            // lvpontod
            // 
            this.lvpontod.Text = "Teljesített szintek";
            this.lvpontod.Width = 103;
            // 
            // lvlmode
            // 
            this.lvlmode.Text = "Mód";
            this.lvlmode.Width = 81;
            // 
            // Ponttablazat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ponttablazat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legyen ön is milliomos";
            this.Load += new System.EventHandler(this.Ponttablazat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listScore;
        private System.Windows.Forms.ColumnHeader lvname;
        private System.Windows.Forms.ColumnHeader lvpontod;
        private System.Windows.Forms.ColumnHeader lvlid;
        private System.Windows.Forms.ColumnHeader lvlmode;
    }
}