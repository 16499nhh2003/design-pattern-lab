package ex2;

public class Printer1 {
    private static Printer1 instance;

    private Printer1() {
    }

    public static Printer1 getInstance() {
        if (instance == null) {
            instance = new Printer1();
        }
        return instance;
    }

    public void print(Packet packet) {
        if (accept(packet)) {
            System.out.println("Printer1 : " +  packet.toString());
        }
    }

    public boolean accept(Packet packet) {
        return true;
    }

}
