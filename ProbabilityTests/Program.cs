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
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Coin.Toss().ToString());
            }
        
            

            Console.ReadKey();
        }
    }
}
