using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _268_Missing_Number_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 0, 1 };
            Console.WriteLine(MissingNumber2(nums));
            Console.ReadLine();
        }
        //Level 1
        // Áp dụng tính chất xor:
        // xor + 0 = xor
        // xor + xor = 0
        // Áp dụng tính chất giao hoán của phép +, A + B = B + A
        // [3, 0, 1]
        // xor
        // [0, 1, 2, 3]
        // Tương đương
        // [3, 0, 1]
        // xor
        // [3, 0, 1, 2]
        // [0, 0, 0, 2] => Các giá trị giống nhau thì xor = 0 => còn sót lại 2 xor 0 = 2.
        public static int MissingNumber(int[] nums)
        {
            int xor = 0;
            // Vì các số n trong khoảng từ 0 - nums.Length nên phải cho i <= nums.Length
            for (int i = 0; i <= nums.Length; i++)
            {
                xor = xor ^ i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                xor = xor ^ nums[i];
            }

            return xor;
        }
        //Level 2
        public static int MissingNumber2(int[] nums)
        {
            // Vì chỉ dùng 1 vòng lặp, nên để chuyển từ <= nums.Length thì ta gán giá trị nums.Length vào trước
            // Như vậy, xor đã có sẵn giá trị nums.Length và không cần phải <= nums.Length nữa.
            int xor = nums.Length;
            // xor cũng có tính chất giao hoán giống như phép +, -, *
            for (int i = 0; i < nums.Length; i++)
            {
                xor ^= nums[i] ^ i;
            }

            return xor;
        }
    }
}
