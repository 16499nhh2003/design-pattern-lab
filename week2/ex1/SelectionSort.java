import java.util.List;

public class SelectionSort implements IStrategySort {

    @Override
    public void sort(List<Integer> items) {
        int n = items.size();
        for (int i = 0; i < n - 1; i++) {
            int min_idx = i;
            for (int j = i + 1; j < n; j++) {
                if (items.get(j) < items.get(min_idx)) {
                    min_idx = j;
                }
            }

            int tmp = items.get(min_idx);
            items.set(min_idx, items.get(i));
            items.set(i, tmp);
        }
    }

}
