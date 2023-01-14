using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductofArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 3, 5, 7, 8 };
            foreach (var item in ProductExceptSelf(ints))
            {
                Console.WriteLine($"{item} ");
            }
            Console.ReadLine();
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            // Kiểm tra đầu vào
            int n = nums.Length;
            if (n < 2)
            {
                return nums;
            }

            int[] left= new int[n];
            int[] right= new int[n];
            int[] result = new int[n];


            int currLeft = 1;
            int currRight = 1;

            for (int i = 0; i < n; i++)
            {
                currLeft *= nums[i];
                currRight *= nums[n - i - 1];
                left[i] = currLeft;
                right[n- i - 1] = currRight;
            }

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    result[i] = right[1];
                }
                else if (i == n - 1)
                {
                    result[i] = left[n - 2];
                }
                else
                {
                    result[i] = left[i - 1] * right[i + 1];
                }
            }

            return result;
        }
    }
}
