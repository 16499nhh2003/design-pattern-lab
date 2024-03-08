import java.util.List;

/**
 * MergeSort
 */
public class MergeSort implements IStrategySort {

    @Override
    public void sort(List<Integer> items) {
        if (items == null || items.size() < 2) {
            return; // No need to sort
        }
        sort(items, 0, items.size() - 1);
    }

    private void merge(List<Integer> items, int l, int m, int r) {
        int n1 = m - l + 1;
        int n2 = r - m;

        // Create temp lists
        List<Integer> L = items.subList(l, m + 1);
        List<Integer> R = items.subList(m + 1, r + 1);

        // Merge the temp lists
        int i = 0, j = 0, k = l;
        while (i < n1 && j < n2) {
            if (L.get(i) <= R.get(j)) {
                items.set(k, L.get(i));
                i++;
            } else {
                items.set(k, R.get(j));
                j++;
            }
            k++;
        }

        // Copy remaining elements of L[] if any
        while (i < n1) {
            items.set(k, L.get(i));
            i++;
            k++;
        }

        // Copy remaining elements of R[] if any
        while (j < n2) {
            items.set(k, R.get(j));
            j++;
            k++;
        }
    }

    private void sort(List<Integer> items, int l, int r) {
        if (l < r) {
            int m = l + (r - l) / 2;
            sort(items, l, m);
            sort(items, m + 1, r);
            merge(items, l, m, r);
        }
    }
}
