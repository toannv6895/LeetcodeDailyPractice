using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _268_Missing_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 0, 1 };
            Console.WriteLine(MissingNumber(nums));
            Console.ReadLine();
        }

        public static int MissingNumber(int[] nums)
        {
            int sum = (nums.Length * (nums.Length + 1)) / 2;

            for (int i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
            }
            return sum;
        }
    }
}
