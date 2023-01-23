using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _371.Sum_of_Two_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1, b = 2;
            int a = 9, b = 11;
            Console.WriteLine(GetSum(a, b));
            Console.ReadLine();
        }

        // Kết hợp toán tử and và dịch sang trái 1 bit, sau đó cộng với giá trị xor
        public static int GetSum(int a, int b)
        {
            while (b != 0)
            {
                int temp = (a & b) << 1;
                a = a ^ b;
                b = temp;
            }
            
            return a;
        }
    }
}
