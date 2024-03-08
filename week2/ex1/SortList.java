import java.util.ArrayList;
import java.util.List;

public class SortList {
    private IStrategySort iStrategySort;

    public void setSortStrategy(IStrategySort strategy) {
        this.iStrategySort = strategy;
    }

    public void sort(List<Integer> items) {
        iStrategySort.sort(items);
    }

    public void print(List<Integer> items) {
        for (Integer item : items) {
            System.out.print(item + " ");
        }
        System.out.println();
    }

}
