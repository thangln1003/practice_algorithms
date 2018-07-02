namespace SortingAlgorithms.Sorts
{
    public static class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        arr[i] ^= arr[j];
                        arr[j] ^= arr[i];
                        arr[i] ^= arr[j];
                    }
                }
            }
        }
    }
}
