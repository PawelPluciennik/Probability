using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prawdopodobienstwo_
{
    public class Statistics
    {


        public static int Factorial(int n)
        {
            if (n >= 0)
            {
                int factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;

            }
            else
            {
                throw new Exception("Blad silni..");
            }
        }

        public static double NewtonBinomial(int N, int K)
        {
            if (K>N)
            {
                throw new Exception("Wspolczynnik k nie moze byc wiekszy od n!");
            }
            else
            {

                double BinomialScore = 0;
                BinomialScore = (Factorial(N) / (Factorial(K) * Factorial(N - K)));
                return BinomialScore;
            }

        }






        public static double BinomialProbability(double P, int N, int K)
        {
            double Score = 0;
            Score = NewtonBinomial(N, K) * Math.Pow(P, K) * Math.Pow(1 - P, N - K);
            return Score;
        }



    }
}
