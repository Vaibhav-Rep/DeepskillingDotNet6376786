namespace FinancialForecasting
{
    public static class Forecasting
    {
        // Uncomment the following method if you want to use CAGR for realistic financial forecasting and modify the program.cs accordingly.


        /* public static double CalculateCAGR(double initialValue, double finalValue, int years)
        {
            return Math.Pow(finalValue / initialValue, 1.0 / years) - 1;
        }


        public static double PredictUsingCAGRRecursive(double currentValue, double cagr, int futureYears)
        {
            if (futureYears == 0)
                return currentValue;


            double nextValue = currentValue * (1 + cagr);
            return PredictUsingCAGRRecursive(nextValue, cagr, futureYears - 1);
        } */
   


        public static double GetAverageGrowth(double[] pastRates)
        {
            double sum = 0;
            foreach (var rate in pastRates)
                sum += rate;
            return sum / pastRates.Length;
        }


        public static double PredictFutureValueRecursive(double currentValue, double avgGrowthRate, int remainingYears)
        {
            if (remainingYears == 0)
                return currentValue;


            double nextValue = currentValue * (1 + avgGrowthRate);
            return PredictFutureValueRecursive(nextValue, avgGrowthRate, remainingYears - 1);
        }
    }
}


