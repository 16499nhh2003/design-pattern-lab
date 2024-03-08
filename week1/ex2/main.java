package ex2;

public class main {
    public static void main(String[] args) {

        Server server = Server.getInstance("server");
        server.setPrinter1(Printer1.getInstance());
        Workstation w1 = new Workstation("w1");

        Packet packet = new Packet(w1.name, server.name, "abc");
        w1.send(packet);
    }
}
