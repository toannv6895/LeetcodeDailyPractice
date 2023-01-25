using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _338.Counting_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums = 5;
            foreach (var item in CountBits(nums))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        // Giống với 191. Number of 1 Bits 
        public static int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            uint mask = 1;
            for (int i = 0; i <= n; i++)
            {
                int count = 0;
                uint temp = (uint)i;
                for (int j = 1; j <= 32; j++)
                {
                    if ((temp & mask) != 0)
                    {
                        count++;
                    }

                    temp = temp >> 1;
                }
                result[i] = count;
            }

            return result;
        }
    }
}
