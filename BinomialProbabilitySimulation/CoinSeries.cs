using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prawdopodobienstwo_
{
    class CoinSeries
    {
        private int _trailsCount;

        private int _headsCount;

        public int HeadsCount
        {
            get { return _headsCount; }
            set { _headsCount = value; }
        }

        private int _tailsCount;

        public int TailsCount
        {
            get { return _tailsCount; }
            set { _tailsCount = value; }
        }


        public CoinSeries(int trialsCount)
        {
            _trailsCount = trialsCount;
        }
      
      
        public void Do()
        {
            _headsCount = 0;
            _tailsCount = 0;
            for (int i = 0; i < _trailsCount; i++)
            {
               
                if (Coin.Toss() == Coin.TossResult.Heads)
                {
                    _headsCount++;
                }
                else
                {
                    _tailsCount++;
                }
            }
        }
    }
}
