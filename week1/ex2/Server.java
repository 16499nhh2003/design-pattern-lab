package ex2;

public class Server extends Node {
    private Printer1 printer1;
    private Printer2 printer2;
    private static Server instance;

    private Server(String name) {
        super(name);
    }

    public static Server getInstance(String name) {
        if (instance == null) {
            instance = new Server(name);
        }
        return instance;
    }


    public void setPrinter1(Printer1 printer1) {
        this.printer1 = printer1;
    }

    public void setPrinter2(Printer2 printer2) {
        this.printer2 = printer2;
    }

    public boolean isForMe(Packet packet) {
        return packet.destination.equals(this.name);
    }

    public boolean accept(Packet packet) {
        return packet.originator.equals(this.name);
    }

    public void processPacket(Packet packet) {
        if (isForMe(packet)) {
            if (printer1 != null) {
                printer1.print(packet);
            } else if (printer2 != null) {
                printer2.print(packet);
            } else {
                System.out.println("No available printer to handle the request.");
            }
        } else {
            System.out.println("Packet not for this server.");
        }
    }

    public void receivePacket(Packet packet) {
        processPacket(packet);
    }

}
