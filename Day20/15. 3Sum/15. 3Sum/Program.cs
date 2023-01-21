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
            //int[] nums = { 0, 0, 0, 0 };

            var result = ThreeSum(nums);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort<int>(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                int findSum = 0 - nums[i];

                while (left < right)
                {
                    if (nums[left] + nums[right] == findSum)
                    {
                        if (!map.ContainsKey(nums[left]) || map[nums[left]] != nums[right])
                        {
                            result.Add(new int[] { nums[i], nums[left], nums[right] });
                        }

                        map[nums[left]] = nums[right];

                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }

                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }

                        left++;
                        right--;
                    }
                    else if (nums[left] + nums[right] > findSum)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return result;
        }
    }
}
