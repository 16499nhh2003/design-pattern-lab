package v3;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;


public class main {
    public static void main(String[] args) {

        int numberOfThreads = 10;
        int numberOfIterations = 5;
        long startTime, endTime;

        ExecutorService executor = Executors.newFixedThreadPool(numberOfThreads);

        startTime = System.currentTimeMillis();

        for (int i = 0; i < numberOfThreads; i++) {
            executor.submit(() -> {
                Logger3 logger = Logger3.getInstance();
                for (int j = 0; j < numberOfIterations; j++) {
                    logger.logMessage("ThreadSafeLogger message");
                }
            });
        }
        endTime = System.currentTimeMillis();
        System.out.println("Time taken for ThreadSafeLogger: " + (endTime - startTime) + "ms");
        executor.shutdown();
    }
}
