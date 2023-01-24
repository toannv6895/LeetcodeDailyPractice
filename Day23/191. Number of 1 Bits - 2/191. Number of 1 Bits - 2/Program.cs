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
            uint num = 0;
            //First time I have take res =1
            //Now res & n gives me last digit of res & 1 
            //now I am left shifting res by 1 everytime and others are 0 in res
            //now that digit which is 1 in res with that position in n will give me 1 or 0
            //but we know others are 0 in res so answer will always be 0 for other position
            //so if that position of 1 in res and position in n gives 1 then result will be !=0
            //hence increase the counter
            for (int i = 1; i <= 32; i++)
            {
                num = mask & n;
                if (num != 0)
                    count++;

                mask = mask << 1;
            }

            return count;
        }
    }
}
