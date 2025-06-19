public class Logger {
// Private static instance of the Logger class
    private static Logger instance;
    
// Private constructor to prevent instantiation from other classes
    private Logger() {
        // Initialize logger configuration here
        System.out.println("Logger instance created");
    }
    
// Public static method to get the instance of Logger
    public static synchronized Logger getInstance() {
        if (instance == null) {
            instance = new Logger();
        }
        return instance;
    }
    
    public void logInfo(String message) {
        System.out.println("[INFO] " + message);
    }
    
    public void logError(String message) {
        System.out.println("[ERROR] " + message);
    }
    
    public void logWarning(String message) {
        System.out.println("[WARNING] " + message);
    }
} 