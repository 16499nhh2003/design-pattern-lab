package v1;
/**
 * Logger
 */
public class Logger1 {
    private static Logger1 uniqueInstance;
    private Logger1(){}

    public static Logger1 getInstance(){
        if(uniqueInstance == null){
            uniqueInstance = new Logger1();
        }
        return uniqueInstance;
    }

    public void logMessage(String msg) {
        // Open File "log.txt"
        // Write Message
        // Close File
    }
    
}