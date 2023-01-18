using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152.Maximum_Product_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, -2, 4 };
            int[] nums2 = { -2, 0, -1 };
            int[] nums3 = { -2, 3, -7, -5 };
            int[] nums4 = { -2, -5, 9 };
            int[] nums5 = { 0, 1, 8, -1 };
            int[] nums6 = { 2, 6, -5, 9, 3 };
            Console.WriteLine(MaxProduct(nums));
            Console.WriteLine(MaxProduct(nums2));
            Console.WriteLine(MaxProduct(nums3));
            Console.WriteLine(MaxProduct(nums4));
            Console.WriteLine(MaxProduct(nums5));
            Console.WriteLine(MaxProduct(nums6));
            Console.ReadLine();

        }

        public static int MaxProduct(int[] nums)
        {
            int maxLeft = nums[0];
            int maxRight = nums[0];

            bool zero = false;

            int curr = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                curr *= nums[i];
                // Trường hợp khi có 0, ta reset lại giá trị current về 1
                if (nums[i] == 0)
                {
                    zero= true;
                    curr = 1;
                    continue;
                }

                maxLeft = Math.Max(curr, maxLeft);
            }

            curr = 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                curr*= nums[i];
                // Trường hợp khi có 0, ta reset lại giá trị current về 1
                if (nums[i] == 0)
                {
                    zero = true;
                    curr = 1;
                    continue;
                }
                maxRight= Math.Max(curr, maxRight);
            }

            if (zero)
            {
                return Math.Max(Math.Max(maxLeft, maxRight), 0);
            }

            return Math.Max(maxLeft, maxRight);
        }
    }
}
