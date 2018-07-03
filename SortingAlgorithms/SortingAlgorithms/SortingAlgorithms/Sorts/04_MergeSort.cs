namespace SortingAlgorithms.Sorts
{
    public class MergeSort
    {
        /*
         * Idea:
         * MergeSort hoạt động kiểu đệ quy:
         * + Đầu tiên chia dữ liệu thành 2 phần, và sắp xếp từng phần
         * + Sau đó gộp 2 phần lại với nhau. Để gộp 2 phần, ta làm như sau:
         *   -> Tạo một dãy A mới để chứa các phần tử sắp xếp.
         *   -> So sánh 2 phần tử đầu tiên của 2 phần. Phần tử nhỏ hơn ta cho vào A và xóa khỏi phần tử tương ứng.
         *   -> Tiếp tục như vậy đến khi ta cho hết các phần tử vào dãy A.
         *   
         *   Complexity: O(N * logN)
         */

        public static int[] Sort(int[] arr, int low, int high)
        {
            int delta = high - low;
            if (delta < 2)
                return new[] { arr[low] };

            int mid = low + delta / 2;

            // Sắp xếp 2 phần
            int[] left = Sort(arr, low, mid);
            int[] right = Sort(arr, mid, high);

            int[] result = new int[left.Length + right.Length];

            int idxL = 0;
            int idxR = 0;
            int i = 0;

            for (; idxL < left.Length && idxR < right.Length; i++)
            {
                if (left[idxL] < right[idxR])
                {
                    result[i] = left[idxL];
                    idxL++;
                }
                else
                {
                    result[i] = right[idxR];
                    idxR++;
                }
            }

            // copy remaining elements
            while (idxL < left.Length)
                result[i++] = left[idxL++];

            while (idxR < right.Length)
                result[i++] = right[idxR++];

            return result;
        }
    }
}
