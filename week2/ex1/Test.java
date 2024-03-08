import java.util.ArrayList;
import java.util.List;

/**
 * Test
 */
public class Test {

    public static void main(String[] args) {
        SortList list = new SortList();
        List<Integer> integers = new ArrayList<Integer>();
        integers.add(9);
        integers.add(8);
        integers.add(7);
        integers.add(6);
        integers.add(5);
        integers.add(4);
        integers.add(3);
        integers.add(2);

        System.out.println("----SelectionSort------");
        list.setSortStrategy(new SelectionSort());
        list.sort(integers);
        list.print(integers);
        System.out.println("----SelectionSort------");

        System.out.println("----QuickSort------");
        list.setSortStrategy(new QuickSort());
        list.sort(integers);
        list.print(integers);
        System.out.println("----QuickSort------");

        System.out.println("----BubbleSort------");
        list.setSortStrategy(new BubbleSort());
        list.sort(integers);
        list.print(integers);
        System.out.println("----BubbleSort------");
    
    }
}