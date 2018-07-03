namespace SortingAlgorithms.Sorts
{
    public static class BubbleSort
    {
        /*
         * Idea:
         * Xét lần lượt các cặp 2 phần tử liên tiếp. Nếu phần tử đứng sau nhỏ hơn phần tử đứng trước, đổi chỗ 2 phần tử
         * 
         * Complexity: O(N^2)
         * 
         */

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
