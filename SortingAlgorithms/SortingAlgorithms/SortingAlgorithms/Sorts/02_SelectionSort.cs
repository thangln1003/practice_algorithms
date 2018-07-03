namespace SortingAlgorithms.Sorts
{
    public static class SelectionSort
    {
        /*
         * Idea:
         * Cho 1 giá trị min, so sánh min với từng phần tử trong mảng, nếu phần tử nhỏ hơn min, đổi trỗ giá trị
         * 
         * Complexity: O(N^2)
         * 
         */
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
