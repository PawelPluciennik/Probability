using Prawdopodobienstwo_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinomialProbabilityPresenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            int trialsInSeries;
            int seriesCount;

            if (!(Int32.TryParse(tBoxTrailsInSeries.Text,out trialsInSeries) && trialsInSeries>0))
            {
                MessageBox.Show("Błęda wartość liczby prób w serii");
                return;
            }

            if (!(Int32.TryParse(tBoxSeriesCount.Text, out seriesCount) && seriesCount >0))
            {
                MessageBox.Show("Błęda wartość liczby serii");
                return;
            }


            chartProbabilityDistribution.Series["Coin flips"].Points.Clear();
            CoinSeriesProbability probability = new CoinSeriesProbability(trialsInSeries, seriesCount);
            probability.Simulate();
            for (int i = 0; i < probability.GetProbability().Length; i++)
            {
                chartProbabilityDistribution.Series["Coin flips"].Points.AddXY(i, probability.GetProbability()[i]);

            }

            double realMean = Statistics.Mean(probability.CoinSeriesProbabilityTab);
            double realSigma =  Statistics.StandardDeviation(probability.CoinSeriesProbabilityTab);

            double theoreticalMean = Statistics.MeanTheory(trialsInSeries, 0.5);
            double theoreticalSigma = Statistics.StandardDeviationTheory(trialsInSeries, 0.5);

            tBoxMean.Text = realMean.ToString("0.##");
            tBoxSigma.Text = realSigma.ToString("0.##");

            tBoxMeanTheory.Text = theoreticalMean.ToString("0.##");
            tBoxSigmaTheory.Text = theoreticalSigma.ToString("0.##");

            tBoxMeanError.Text = Statistics.RelativeError(realMean, theoreticalMean).ToString("0.##");
            tBoxSigmaError.Text = Statistics.RelativeError(realSigma, theoreticalSigma).ToString("0.##");
        }
    }
}
