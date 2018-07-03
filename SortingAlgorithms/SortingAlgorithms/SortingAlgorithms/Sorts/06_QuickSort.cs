using System;

namespace SortingAlgorithms.Sorts
{
    public static class QuickSort
    {
        /*
         * Idea:
         * Chia 2 dãy thành 2 phần, một phần "lớn" và một phần "nhỏ"
         * -> Chọn một khóa pivot
         * -> Những phần tử lớn hơn pivot chia vào phần lớn
         * -> Những phần tử nhỏ hơn hoặc bằng pivot chia vào phần nhỏ
         * Gọi đệ quy để sắp xếp 2 phần (Recursive calls)
         * 
         */
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Sort(arr, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
