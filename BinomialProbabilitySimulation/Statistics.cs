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

        

        public static double Mean(int[] tab)
        {
            int sum = 0;
            int N= 0;
            for (int i = 0; i < tab.Length; i++)
            {
                sum += tab[i] * i;
                N += tab[i];
            }

            return 1.0 * sum / N;
        }

        public static double MeanTheory(int trialsInSeries, double trialProbability)
        {
            return 1.0*trialsInSeries * trialProbability;
        }

        public static double StandardDeviationTheory(int trialsInSeries, double trialProbability)
        {
            return Math.Sqrt(1.0* trialsInSeries * trialProbability*(1-trialProbability));
        }

        public static double RelativeError(double exactValue, double theoreticalValue)
        {
            return (exactValue - theoreticalValue) / exactValue*100;
        }


        public static double StandardDeviation(int[] tab)
        {
            double mean = Mean(tab);
            double sum = 0;
            int N = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                sum += ((double)i - mean) * ((double)i - mean) * (double)tab[i];
                N += tab[i];
            }

            double sigma = Math.Sqrt(sum / N);

            return sigma;

        }
    }
}
