using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _153.Find_Minimum_in_Rotated_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 3, 4, 5, 1, 2 };
            //int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            //int[] nums = { 11, 13, 15, 17 };
            //int[] nums = { 2, 1 };
            //int[] nums = { 2, 3, 1 };
            int[] nums = { 2, 3, 4, 5, 1 };
            //int[] nums = { 7, 8, 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(FindMin(nums));
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        //You must write an algorithm that runs in O(log n) time.
        public static int FindMin(int[] nums)
        {
            int n = nums.Length;

            if (n == 0)
            {
                return -1;
            }

            if (n == 1)
            {
                return nums[0];
            }

            int left = 0;
            int right = n - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (mid > 0 && nums[mid] < nums[mid - 1])
                {
                    return nums[mid];
                }
                else if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right= mid;
                }
            }

            return nums[left];
        }
    }
}
