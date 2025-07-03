using System;
using System.IO;


namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {


            // Note using average growth rate from past 10 years but is not realistic to realworld


            /* We can use CAGR (Compound Annual Growth Rate) for realistic financial forecasting,
             using initial and current value to precdict CAGR and use for future forecasting */


            // using a default stored array of past 10 years growth rates
            double[] pastGrowthRates = new double[]
            {   0.04, // 4%
                0.05, // 5%
                0.03, // 3%
                0.06, // 6%
                0.02, // 2%
                0.01, // 1%
                -0.01, // -1%
                0.03, // 3%
                0.04, // 4%
                0.02 // 2%
            };


            Console.Write("Enter the current value of the investment (in ₹): ");
            double currentValue = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter the number of years to predict the future value: ");
            int futureYears = Convert.ToInt32(Console.ReadLine());




            // calculating average growth rate from past 10 years
            double avgGrowth = Forecasting.GetAverageGrowth(pastGrowthRates);
            Console.WriteLine($"Average Growth Rate from past 10 years: {avgGrowth * 100:F2}%");


            // calling the recursive method to predict future value
            double predicted = Forecasting.PredictFutureValueRecursive(currentValue, avgGrowth, futureYears);


            Console.WriteLine($" Predicted Value after {futureYears} years (using recursion): ₹{predicted:F2}");
        }
    }
}





