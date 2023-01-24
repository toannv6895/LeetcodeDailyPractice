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
            string s = n.ToString();
            int result = 0;
            foreach (char c in s)
            {
                if (c == '1')
                {
                    result++;
                }
            }

            return result;
        }
    }
}
