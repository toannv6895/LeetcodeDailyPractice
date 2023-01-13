using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(ContainsDuplicate(ints));
            Console.ReadLine();
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    return true;
                }

                dic[nums[i]] = 1;
            }

            return false;
        }
    }
}
