namespace Assignment6._2._2
{
    internal class Program
    {
        public static int[] ProductExceptFirstElement(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            answer[0] = 1;
            for (int i = 1; i < n; i++)
            {
                answer[i] = nums[i - 1] * answer[i - 1];
            }

            int suffixProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] = answer[i] * suffixProduct;
                suffixProduct *= nums[i];
            }

            return answer;
        }

        public static void DisplayArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
        static void Main(string[] args)
        {
            int[] nums = { -1, 1, 0, -3, 3 };
            DisplayArray(nums);
            DisplayArray(ProductExceptFirstElement(nums));
        }
    }
}
