package v3;

public class Logger3 {
    private static volatile Logger3 instance;

    private Logger3() {
    }

    public static Logger3 getInstance() {
        if (instance == null) {
            synchronized (Logger3.class) {
                if (instance == null) {
                    instance = new Logger3();
                }
            }
        }
        return instance;
    }

    public void logMessage(String msg) {
        // Open File "log.txt"
        // Write Message
        // Close File
    }

}
