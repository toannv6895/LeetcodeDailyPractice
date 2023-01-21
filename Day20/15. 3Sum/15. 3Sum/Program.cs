using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };

            var result = ThreeSum(nums);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<string, IList<int>> result0 = new Dictionary<string, IList<int>>();

            Array.Sort<int>(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int curr = nums[left] + nums[right] + nums[i];

                    if (curr == 0)
                    {
                        //result.Add(new int[] { nums[i], nums[left], nums[right] });
                        result0[$"{nums[i]},{nums[left]},{nums[right]}"] = new int[] { nums[i], nums[left], nums[right] };
                        left++;
                    }
                    else if (curr > 0)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            foreach (var item in result0.Values)
            {
                result.Add(item);
            }

            return result;
        }
    }
}
