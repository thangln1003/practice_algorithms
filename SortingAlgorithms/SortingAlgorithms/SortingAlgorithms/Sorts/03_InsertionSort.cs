namespace SortingAlgorithms.Sorts
{
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
