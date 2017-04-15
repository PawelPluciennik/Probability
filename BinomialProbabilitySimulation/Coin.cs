using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prawdopodobienstwo_
{
    public class Coin
    {
        static Random random = new Random();

        public enum TossResult
        {
            Heads,
            Tails
        }

        public static TossResult Toss()
        {
            
            if (random.Next(1,3) == 1)
            {
                return TossResult.Heads;
            }
            else
            {
                return TossResult.Tails;
            }
        }


    }
}
