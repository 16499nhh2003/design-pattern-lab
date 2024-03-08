package ex2;

public class Printer2 {
    private static Printer2 instance;

    private Printer2() {
    }

    public static Printer2 getInstance() {
        if (instance == null) {
            instance = new Printer2();
        }
        return instance;
    }

    public void print(Packet packet) {
        System.out.println("Printer 2:  " + packet.toString());
    }

    public boolean accept(Packet packet) {
        return false;
    }

}
