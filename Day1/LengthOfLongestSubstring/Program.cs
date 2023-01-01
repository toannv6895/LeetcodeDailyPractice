using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLongestSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcabcbb";
            string s2 = "bbbbb";
            string s3 = "pwwkew";
            Console.WriteLine(LengthOfLongestSubstring(s1));
            Console.WriteLine(LengthOfLongestSubstring(s2));
            Console.WriteLine(LengthOfLongestSubstring(s3));
            Console.ReadKey();
        }

        public static int LengthOfLongestSubstring(string s)
        {
            // Kiểm tra biến đầu vào có hợp lệ hay không
            if (s == null)
            {
                return 0;
            }
            if (s.Length < 2)
            {
                return s.Length;
            }

            int max = 1;
            StringBuilder tempBuilder = new StringBuilder().Append(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                String stringTemp = tempBuilder.ToString();
                tempBuilder.Append(s[i]);
                if (stringTemp.Contains(s[i]))
                {
                    stringTemp = tempBuilder.ToString().Substring(stringTemp.IndexOf(s[i]) + 1);
                    tempBuilder = new StringBuilder(stringTemp);
                }
                else
                {
                    max = Math.Max(max, tempBuilder.ToString().Length);
                }
            }
            return max;
        }
    }
}
