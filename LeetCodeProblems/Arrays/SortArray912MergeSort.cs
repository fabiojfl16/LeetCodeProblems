namespace LeetCode.Arrays;

public class SortArray912MergeSort
{
    /// <summary>
    /// Merge Sort Algorithm: n log n
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public void SortArray(int[] arr)
    {
        int[] temp = new int[arr.Length];
        Sort(arr, temp, 0, arr.Length - 1);
    }

    private void Sort(int[] arr, int[] temp, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            Sort(arr, temp, left, middle);
            Sort(arr, temp, middle + 1, right);
            Merge(arr, temp, left, middle, right);
        }
    }

    private static void Merge(int[] arr, int[] temp, int left, int middle, int right)
    {
        for (int i = left; i <= right; i++)
        {
            temp[i] = arr[i];
        }

        int leftIndex = left;
        int rightIndex = middle + 1;
        int currentIndex = left;

        while (leftIndex <= middle && rightIndex <= right)
        {
            if (temp[leftIndex] <= temp[rightIndex])
            {
                arr[currentIndex] = temp[leftIndex];
                leftIndex++;
            }
            else
            {
                arr[currentIndex] = temp[rightIndex];
                rightIndex++;
            }

            currentIndex++;
        }

        while (leftIndex <= middle)
        {
            arr[currentIndex] = temp[leftIndex];
            leftIndex++;
            currentIndex++;
        }
    }
}