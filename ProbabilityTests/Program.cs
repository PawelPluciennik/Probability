using Prawdopodobienstwo_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityTests
{
    class Program
    {
        static void Main(string[] args)
        {

            CoinSeriesProbability probability = new CoinSeriesProbability(10, 10000);

            probability.Simulate();

            for (int i = 0; i < probability.CoinSeriesProbabilityTab.Length; i++)
            {
                Console.WriteLine(String.Format("Heads in series {0} - count: {1}", i,probability.GetProbability()[i]));
            }

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
