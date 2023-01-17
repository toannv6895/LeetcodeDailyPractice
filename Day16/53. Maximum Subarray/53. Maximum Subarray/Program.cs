using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Maximum_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int[] nums1 = { 1};
            int[] nums2 = { 5, 4, -1, 7, 8 };
            Console.WriteLine(MaxSubArray(nums));
            Console.WriteLine(MaxSubArray(nums1));
            Console.WriteLine(MaxSubArray(nums2));
            Console.ReadLine();
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }

            int n = nums.Length;
            int curr = 0;
            int max = nums[0];
            int left = 0;

            for (int i = 0; i < n; i++)
            {
                curr += nums[i];
                max = Math.Max(max, curr);

                while ((curr < 0 || nums[left] < 0) && left < i)
                {
                    curr = curr - nums[left];
                    max = Math.Max(max, curr);
                    left++;
                }
            }

            return max;
        }
    }
}
