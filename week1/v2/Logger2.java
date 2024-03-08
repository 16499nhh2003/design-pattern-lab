package v2;

public class Logger2 {
    private static volatile Logger2 instance;
    private Logger2(){}

    public static synchronized Logger2 getInstance(){
        if(instance == null){
            instance = new Logger2();
        }
        return instance;
    }

    public void logMessage(String msg) {
        // Open File "log.txt"
        // Write Message
        // Close File
    }

}
