using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 7, 8, 9, 10, 11, };
            int target = 9;
            Console.WriteLine(TwoSum(ints, target));
            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2)
            {
                return null;
            }

            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(target - nums[i]))
                {
                    dic[nums[i]] = i;
                }
                else
                {
                    result[0] = dic[target - nums[i]];
                    result[1] = i;
                    break;
                }
            }

            return result;
        }
    }
}
