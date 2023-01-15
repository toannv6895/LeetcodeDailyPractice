using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ints = { 0, 1, 0, 3, 12 };
            //int[] ints = { 1,0,1};
            int[] ints = { 2, 1 };
            var result = MoveZeroes(ints);
            foreach (var item in result)
            {
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public static int[] MoveZeroes(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums;
            }
            int l = 0;
            int r = 1;

            while (l < r && r < nums.Length)
            {
                if (nums[l] == 0 && nums[r] != 0)
                {
                    int temp = nums[r];
                    nums[r] = nums[l];
                    nums[l] = temp;
                    l++;
                }

                while (l < nums.Length && nums[l] != 0)
                {
                    l++;
                }

                if (l >= r)
                {
                    r = l + 1;
                }
                else
                {
                    r++;
                }
            }

            return nums;
        }
    }
}
