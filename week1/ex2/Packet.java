package ex2;

public class Packet {
    protected String originator;
    protected String destination;
    protected String contents;

    public Packet(String originator, String destination, String contents) {
        this.originator = originator;
        this.destination = destination;
        this.contents = contents;
    }

    public boolean isOriginator(Node node) {
        return originator.equals(node.name);
    }

    public boolean isDestination(Node node) {
        return destination.equals(node.name);
    }

    public String getContents() {
        return contents;
    }

    @Override
    public String toString() {
        return "Packet{" +
                "originator='" + originator + '\'' +
                ", destination='" + destination + '\'' +
                ", contents='" + contents + '\'' +
                '}';
    }
}