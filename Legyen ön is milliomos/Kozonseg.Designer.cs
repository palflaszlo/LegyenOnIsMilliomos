namespace Legyen_ön_is_milliomos
{
    partial class Kozonseg
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.kozonsegChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.kozonsegChart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kozonsegChart
            // 
            chartArea4.Name = "ChartArea1";
            this.kozonsegChart.ChartAreas.Add(chartArea4);
            this.kozonsegChart.Location = new System.Drawing.Point(13, 13);
            this.kozonsegChart.Name = "kozonsegChart";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.kozonsegChart.Series.Add(series4);
            this.kozonsegChart.Size = new System.Drawing.Size(300, 300);
            this.kozonsegChart.TabIndex = 3;
            this.kozonsegChart.Text = "chart1";
            // 
            // Kozonseg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 353);
            this.Controls.Add(this.kozonsegChart);
            this.Controls.Add(this.button1);
            this.Name = "Kozonseg";
            this.Text = "Kozonseg";
            this.Load += new System.EventHandler(this.Kozonseg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kozonsegChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart kozonsegChart;
    }
}