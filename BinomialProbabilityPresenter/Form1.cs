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
            chartProbabilityDistribution.Series["Coin flips"].Points.Clear();
            CoinSeriesProbability probability = new CoinSeriesProbability(50, 100000);
            probability.Simulate();
            for (int i = 0; i < probability.GetProbability().Length; i++)
            {
                chartProbabilityDistribution.Series["Coin flips"].Points.AddXY(i, probability.GetProbability()[i]);

            }
        }
    }
}
