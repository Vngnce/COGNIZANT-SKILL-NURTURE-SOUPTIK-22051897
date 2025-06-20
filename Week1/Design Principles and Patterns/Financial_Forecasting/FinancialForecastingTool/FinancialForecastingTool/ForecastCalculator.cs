namespace FinancialForecasting
{
    public static class ForecastCalculator
    {
        public static double PredictFutureValue(double initialValue, double growthRate, int years)
        {
            if (years == 0)
                return initialValue;
            return PredictFutureValue(initialValue, growthRate, years - 1) * (1 + growthRate);
        }
    }
}
