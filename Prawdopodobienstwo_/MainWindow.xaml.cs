using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prawdopodobienstwo_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

#if DEBUG

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int number = Int32.Parse(tBoxNumber.Text);
            int result = Statistics.Factorial(number);
            tBoxResult.Text = result.ToString();
        }

        private void btnCalculateNK_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(tBoxN.Text);
            int k = Int32.Parse(tBoxK.Text);
            double BinomialNewton = Statistics.NewtonBinomial(n, k);
            tBoxBinomialScore.Text = BinomialNewton.ToString();
        }

        private void btnCalculateBinomialProbability_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(tBoxN.Text);
            int k = Int32.Parse(tBoxK.Text);
            double p = Double.Parse(tBoxP.Text);
            double binomialProbabilityResult = Statistics.BinomialProbability(p,n, k);
            tBoxProbabilityScore.Text = binomialProbabilityResult.ToString();
        }

#endif


    }
}
