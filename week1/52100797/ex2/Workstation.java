package ex2;


public class Workstation extends Node {

    public Workstation(String name) {
        super(name);
    }

    public void originate() {

    }

    public void send(Packet packet) {
        Server destination = Server.getInstance(packet.destination);
        boolean flag = accept(packet);
        if (flag) {
            destination.receivePacket(packet);
        } else {
            System.out.println("Workstation " + this.name + " rejected the packet: " + packet.toString());
        }
    }

    public boolean accept(Packet p) {
        return p.isOriginator(this);
    }
}
