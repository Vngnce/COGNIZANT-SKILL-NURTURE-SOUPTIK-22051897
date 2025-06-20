using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.Instance;
            logger1.Log("First message");

            Logger logger2 = Logger.Instance;
            logger2.Log("Second message");

            // Check if both logger references are the same
            if (ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("Both loggers are the same instance.");
            }
            else
            {
                Console.WriteLine("Different logger instances.");
            }

            Console.ReadLine(); // Keeps console window open
        }
    }
}
