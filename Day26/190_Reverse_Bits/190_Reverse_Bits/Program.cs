using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190_Reverse_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = 0b_00000010100101000001111010011100;
            Console.WriteLine(reverseBits(n));
            Console.ReadLine();
        }
        // Tưởng tượng rằng ta có 1 queue để lưu trữ các giá trị từ 1 stack không ngừng bị đẩy về từ phía bên phải
        // Khi đó, các giá trị cuối cùng sẽ dần dần bị đẩy lên phía trước
        // Để làm được điều đó, ta cần dịch trái kết quả đầu ra và dịch phải giá trị đầu vào trong vòng lặp
        //[00000010100101000001111010011100] => Dịch phải
        // &
        //[00000000000000000000000000000001]
        //[00000000000000000000000000000000] <= Dịch trái để nhận kết quả và đẩy kết quả trước đó dần lên phía đầu tiên

        public static uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                // Khi left/right shift thì sẽ chèn số 0 vào vị trí cuối cùng
                // 0 mà right/left shift thì giá trị không thay đổi
                // Ta cần left shift result trước để đảm bảo khi nhận được kết quả cuối cùng sẽ không bị left shift làm thay đổi
                // giá trị
                result = result << 1;
                if ((n & 1) == 1)
                {
                    result++;
                }
                
                n = n >> 1;
            }

            return result;
        }
    }
}
