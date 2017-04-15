namespace BinomialProbabilityPresenter
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProbabilityDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSimulate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartProbabilityDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProbabilityDistribution
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProbabilityDistribution.ChartAreas.Add(chartArea1);
            this.chartProbabilityDistribution.Location = new System.Drawing.Point(12, 63);
            this.chartProbabilityDistribution.Name = "chartProbabilityDistribution";
            this.chartProbabilityDistribution.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Coin flips";
            this.chartProbabilityDistribution.Series.Add(series1);
            this.chartProbabilityDistribution.Size = new System.Drawing.Size(785, 343);
            this.chartProbabilityDistribution.TabIndex = 0;
            this.chartProbabilityDistribution.Text = "probabilityDistribution";
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(12, 12);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(157, 34);
            this.btnSimulate.TabIndex = 1;
            this.btnSimulate.Text = "Symulacja";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 418);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.chartProbabilityDistribution);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartProbabilityDistribution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProbabilityDistribution;
        private System.Windows.Forms.Button btnSimulate;
    }
}

