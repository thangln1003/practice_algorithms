namespace SortingAlgorithms.Sorts
{
    /*
     * Idea:
     * Sắp xếp lần lượt từng đoạn gồm 1 phần tử đầu tiên, 2 phần tử đầu tiên, ..., N phần tử
     * Giả sử ta đã sắp xếp xong i phần tử của mảng. Để sắp xếp i + 1 phần tử đầu tiên, 
     * ta tìm vị trí phù hợp của phần tử thứ i + 1
     * 
     * Complexity: O(N^2)
     * 
     */

    public static class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // Tìm vị trí phù hợp cho i
                int j = i;

                while (j > 0 && arr[i] < arr[j-1])
                {
                    --j;
                }

                // Đưa i về đúng vị trí
                int temp = arr[i];
                for (int k = i; k > j; k--)
                {
                    arr[k] = arr[k - 1];
                }

                arr[j] = temp;
            }
        }
    }
}
