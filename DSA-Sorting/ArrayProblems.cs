namespace DSA_Sorting;
public class ArrayProblems
{

    public void MergeSort(int start, int end, int[] arr)
    {
        if (start >= end)
            return;

        int mid = start + (end - start) / 2;

        MergeSort(start, mid, arr);
        MergeSort(mid + 1, end, arr);
        SortArray(start, mid, end, arr);
    }
    private void SortArray(int start, int mid, int end, int[] arr)
    {
        int[] tempArr = new int[end - start + 1];
        int i = start, j = mid + 1;
        int index = 0;

        while (i <= mid && j <= end)
        {
            tempArr[index++] = arr[i] > arr[j] ? arr[j++] : arr[i++];
        }

        while (i <= mid)
        {
            tempArr[index++] = arr[i++];
        }
        while (j <= end)
        {
            tempArr[index++] = arr[j++];
        }

        for (int x = 0; x < tempArr.Length; x++)
        {
            arr[start + x] = tempArr[x];
        }
    }
}
