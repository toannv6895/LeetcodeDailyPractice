using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Container_With_Most_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] nums = { 1, 1 };
            Console.WriteLine(MaxArea(nums));
            Console.ReadLine();
        }

        public static int MaxArea(int[] height)
        {
            int n = height.Length;
            int left = 0;
            int right = n - 1;
            int max = 0;

            if (height == null || height.Length < 2)
            {
                return 0;
            }

            while (left < right)
            {
                max = Math.Max(max, (right - left) * Math.Min(height[left], height[right]));

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return max;
        }
    }
}
