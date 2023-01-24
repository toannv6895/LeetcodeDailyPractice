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
                // Dựa vào việc n hay mask đặt trước & operator, thì khi đó giá trị của bit sẽ được lưu vào địa chỉ vùng nhớ của biến đó
                // Trong trường hợp này, t dùng n & mask => giá trị mới sẽ lưu vào n, khi đó ta cần dùng phép dịch phải n để thực hiện
                // cho vòng lặp tiếp theo thay vì dịch trái nếu lưu vào mask như ở solution 2 (191. Number of 1 Bits - 3).
                // Tại sao n phải dịch phải? Vì nếu dịch trái thì giá trị bit cuối cùng của n luôn là 0, khi đó 0 & 1 => luôn = 0.
                // Bởi vì dịch trái là sẽ chèn thêm 0 vào bên phải cuối cùng của n.

                // Cũng bởi vì toán tử bit luôn lưu giá trị mới vào biến bên trái toán tử, vì vậy ta không cần thiết phải dùng 1 biến 
                // khác để lưu trữ.
                if ((n & mask) != 0)
                {
                    count++;
                }

                n = n >> 1;
            }

            return count;
        }
    }
}
