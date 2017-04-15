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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProbabilityDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.tBoxTrailsInSeries = new System.Windows.Forms.TextBox();
            this.tBoxSeriesCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxSigma = new System.Windows.Forms.TextBox();
            this.tBoxMean = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxSigmaTheory = new System.Windows.Forms.TextBox();
            this.tBoxMeanTheory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxSigmaError = new System.Windows.Forms.TextBox();
            this.tBoxMeanError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartProbabilityDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProbabilityDistribution
            // 
            chartArea3.Name = "ChartArea1";
            this.chartProbabilityDistribution.ChartAreas.Add(chartArea3);
            this.chartProbabilityDistribution.Location = new System.Drawing.Point(12, 63);
            this.chartProbabilityDistribution.Name = "chartProbabilityDistribution";
            this.chartProbabilityDistribution.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Name = "Coin flips";
            this.chartProbabilityDistribution.Series.Add(series3);
            this.chartProbabilityDistribution.Size = new System.Drawing.Size(785, 343);
            this.chartProbabilityDistribution.TabIndex = 0;
            this.chartProbabilityDistribution.Text = "probabilityDistribution";
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(640, 12);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(157, 34);
            this.btnSimulate.TabIndex = 1;
            this.btnSimulate.Text = "Symulacja";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // tBoxTrailsInSeries
            // 
            this.tBoxTrailsInSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxTrailsInSeries.Location = new System.Drawing.Point(156, 23);
            this.tBoxTrailsInSeries.Name = "tBoxTrailsInSeries";
            this.tBoxTrailsInSeries.Size = new System.Drawing.Size(75, 26);
            this.tBoxTrailsInSeries.TabIndex = 2;
            this.tBoxTrailsInSeries.Text = "10";
            // 
            // tBoxSeriesCount
            // 
            this.tBoxSeriesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxSeriesCount.Location = new System.Drawing.Point(339, 23);
            this.tBoxSeriesCount.Name = "tBoxSeriesCount";
            this.tBoxSeriesCount.Size = new System.Drawing.Size(113, 26);
            this.tBoxSeriesCount.TabIndex = 2;
            this.tBoxSeriesCount.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba prób w serii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(246, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba serii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(24, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odchylenie standardowe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(24, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Średnia:";
            // 
            // tBoxSigma
            // 
            this.tBoxSigma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxSigma.Location = new System.Drawing.Point(222, 473);
            this.tBoxSigma.Name = "tBoxSigma";
            this.tBoxSigma.ReadOnly = true;
            this.tBoxSigma.Size = new System.Drawing.Size(75, 26);
            this.tBoxSigma.TabIndex = 5;
            // 
            // tBoxMean
            // 
            this.tBoxMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxMean.Location = new System.Drawing.Point(222, 441);
            this.tBoxMean.Name = "tBoxMean";
            this.tBoxMean.ReadOnly = true;
            this.tBoxMean.Size = new System.Drawing.Size(75, 26);
            this.tBoxMean.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(8, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Wyniki z symulacji:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(344, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Wyniki teoretyczne:";
            // 
            // tBoxSigmaTheory
            // 
            this.tBoxSigmaTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxSigmaTheory.Location = new System.Drawing.Point(348, 473);
            this.tBoxSigmaTheory.Name = "tBoxSigmaTheory";
            this.tBoxSigmaTheory.ReadOnly = true;
            this.tBoxSigmaTheory.Size = new System.Drawing.Size(75, 26);
            this.tBoxSigmaTheory.TabIndex = 9;
            // 
            // tBoxMeanTheory
            // 
            this.tBoxMeanTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxMeanTheory.Location = new System.Drawing.Point(348, 441);
            this.tBoxMeanTheory.Name = "tBoxMeanTheory";
            this.tBoxMeanTheory.ReadOnly = true;
            this.tBoxMeanTheory.Size = new System.Drawing.Size(75, 26);
            this.tBoxMeanTheory.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(514, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Błąd względny (%)";
            // 
            // tBoxSigmaError
            // 
            this.tBoxSigmaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxSigmaError.Location = new System.Drawing.Point(518, 473);
            this.tBoxSigmaError.Name = "tBoxSigmaError";
            this.tBoxSigmaError.ReadOnly = true;
            this.tBoxSigmaError.Size = new System.Drawing.Size(75, 26);
            this.tBoxSigmaError.TabIndex = 12;
            // 
            // tBoxMeanError
            // 
            this.tBoxMeanError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxMeanError.Location = new System.Drawing.Point(518, 441);
            this.tBoxMeanError.Name = "tBoxMeanError";
            this.tBoxMeanError.ReadOnly = true;
            this.tBoxMeanError.Size = new System.Drawing.Size(75, 26);
            this.tBoxMeanError.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBoxSigmaError);
            this.Controls.Add(this.tBoxMeanError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBoxSigmaTheory);
            this.Controls.Add(this.tBoxMeanTheory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxSigma);
            this.Controls.Add(this.tBoxMean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxSeriesCount);
            this.Controls.Add(this.tBoxTrailsInSeries);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.chartProbabilityDistribution);
            this.Name = "Form1";
            this.Text = "Symulacja rzutów monetą";
            ((System.ComponentModel.ISupportInitialize)(this.chartProbabilityDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProbabilityDistribution;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.TextBox tBoxTrailsInSeries;
        private System.Windows.Forms.TextBox tBoxSeriesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxSigma;
        private System.Windows.Forms.TextBox tBoxMean;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxSigmaTheory;
        private System.Windows.Forms.TextBox tBoxMeanTheory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxSigmaError;
        private System.Windows.Forms.TextBox tBoxMeanError;
    }
}

