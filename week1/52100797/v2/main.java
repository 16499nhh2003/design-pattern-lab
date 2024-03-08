package v2;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class main {
    public static void main(String[] args) {
        int numberOfThreads = 10;
        int numberOfIterations = 5;

        ExecutorService executor = Executors.newFixedThreadPool(numberOfThreads);

        long startTime, endTime;
        startTime = System.currentTimeMillis();

        for (int i = 0; i < numberOfThreads; i++) {
            executor.submit(() -> {
                Logger2 logger = Logger2.getInstance();
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
