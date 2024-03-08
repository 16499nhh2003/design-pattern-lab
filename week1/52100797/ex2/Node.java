package ex2;

class Node {
    protected String name;
    protected Node nextNode;

    public Node(){
        this.name = "";
        this.nextNode =  null;
    }

    public Node(String name) {
        this.name = name;
        this.nextNode = null;
    }

    public Node(String name , Node nextNode){
        this.name =  name;
        this.nextNode = nextNode;
    }

    public boolean accept(Packet packet) {
        return packet.destination.equals(this.name);
    }

    public void insertNode(Node n) {
        n.nextNode = nextNode;
        nextNode = n;
    }

    public Node nextNode() {
        return this.nextNode;
    }

}
