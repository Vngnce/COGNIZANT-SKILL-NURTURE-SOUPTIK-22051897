public class LoggerTest {
    public static void main(String[] args) {
        Logger logger1 = Logger.getInstance();
        logger1.logInfo("First logger instance created");
              
        Logger logger2 = Logger.getInstance();
        logger2.logInfo("Second logger instance requested");
               
        if (logger1 == logger2) {
            System.out.println("Success: Both logger references point to the same instance");
        } else {
            System.out.println("Error: Different instances were created");
        }
        
        logger1.logWarning("This is a warning message");
        logger2.logError("This is an error message");
    }
} 