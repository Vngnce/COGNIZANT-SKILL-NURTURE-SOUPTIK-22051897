using System;

public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    // Private constructor ensures no external instantiation
    private Logger()
    {
        Console.WriteLine("Logger Initialized");
    }

    public static Logger Instance
    {
        get
        {
            // Double-checked locking for thread-safety
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }
    }

    public void Log(string message)
    {
        Console.WriteLine("[LOG] " + message);
    }
}
