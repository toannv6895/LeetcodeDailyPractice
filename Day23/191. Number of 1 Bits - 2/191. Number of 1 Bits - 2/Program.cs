using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191.Number_of_1_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint nums = 00000000000000000000000000001011;
            Console.WriteLine(HammingWeight(nums));
            Console.ReadLine();
        }

        public static int HammingWeight(uint n)
        {
            uint mask = 1;
            int count = 0;
            for (int i = 1; i <= 32; i++)
            {
                if ((mask & n) != 0)
                {
                    count++;
                }

                mask = mask << 1;
            }

            return count;
        }
    }
}
