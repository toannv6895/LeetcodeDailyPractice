using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLongestSubstring2
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

            int max = 0;
            int j = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; ++i)
            {
                if (map.ContainsKey(s[i]))
                {
                    j = Math.Max(j, map[s[i]] + 1);
                }
                map[s[i]] = i;
                max = Math.Max(max, i - j + 1);
            }
            return max;
        }
    }
}
