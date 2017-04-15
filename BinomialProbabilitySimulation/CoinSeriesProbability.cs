using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prawdopodobienstwo_
{
    public class CoinSeriesProbability
    {
        private int _trialsInSeries;
        private int _seriesCount;

        private int[] _coinSeriesProbabilityTab;

        public int[] CoinSeriesProbabilityTab      
        {
            get { return _coinSeriesProbabilityTab; }
            set { _coinSeriesProbabilityTab = value; }
        }

        
        

        public CoinSeriesProbability(int trialsInSeries, int seriesCount)
        {
            _trialsInSeries = trialsInSeries;
            _seriesCount = seriesCount;

            _coinSeriesProbabilityTab = new int[trialsInSeries+1];
        }

        public void Simulate()
        {
            CoinSeries coinSeries = new CoinSeries(_trialsInSeries);

            for (int i = 0; i < _seriesCount; i++)
            {
                coinSeries.Do();
                _coinSeriesProbabilityTab[coinSeries.HeadsCount]++;
            }
        }

        public double[] GetProbability()
        {
            double[] probability = new double[_coinSeriesProbabilityTab.Length];
            for (int i = 0; i < probability.Length; i++)
            {
                probability[i] = 1.0*_coinSeriesProbabilityTab[i] / _seriesCount * 100;
            }

            return probability;
        }

    }
}
