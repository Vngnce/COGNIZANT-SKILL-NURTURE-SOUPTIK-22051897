using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Financial Forecasting Tool ===");

            Console.Write("Enter Initial Value (e.g., Revenue): ");
            double initialValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Annual Growth Rate (%): ");
            double growthRatePercent = Convert.ToDouble(Console.ReadLine());
            double growthRate = growthRatePercent / 100.0;

            Console.Write("Enter Number of Years to Forecast: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double futureValue = ForecastCalculator.PredictFutureValue(initialValue, growthRate, years);
            Console.WriteLine($"\nPredicted Value after {years} years: {futureValue:F2}");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
