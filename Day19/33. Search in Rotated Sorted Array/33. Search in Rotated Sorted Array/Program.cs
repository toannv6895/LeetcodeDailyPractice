using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Search_in_Rotated_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            //int[] nums = { 1,2,3, 4, 5, 6, 7 };
            //int[] nums = { 1, 3 };
            //int[] nums = { 5, 1, 3 };
            int[] nums = { 1, 3 };
            int target = 2;

            Console.WriteLine(Search(nums, target));

            Console.ReadLine();
        }

        public static int Search(int[] nums, int target)
        {
            int n = nums.Length;

            int left = 0;
            int right = n - 1;

            if (n == 1)
            {
                if (nums[0] == target)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

            // Tìm vị trí giá trị nhỏ nhất của mảng xoay
            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            // Khi đó, nếu nums là 1 mảng xoay, thì ta có thể biết được target nằm trong phần xoay nào của nums dựa trên
            // giá trị nhỏ nhất đã tìm được ở trên
            int start = left;
            left = 0;
            right = n - 1;

            if (target >= nums[start] && target <= nums[right])
            {
                left = start;
            }
            else
            {
                right = start;
            }

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
