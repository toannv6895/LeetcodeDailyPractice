using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicSubstrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "abccba";
            string s3 = "abcba";
            string s4 = "aaa";
            //Console.WriteLine(CountSubstrings(s1));
            //Console.WriteLine(CountSubstrings(s2));
            //Console.WriteLine(CountSubstrings(s3));
            Console.WriteLine(CountSubstrings(s4));
            Console.ReadKey();
        }

        public static int CountSubstrings(string s)
        {
            if (s == null)
            {
                return 0;
            }

            if (s.Length < 2)
            {
                return s.Length;
            }

            int resut = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int l0 = i - 1;
                int l1 = i;
                int r = i + 1;
                while (r < s.Length && (l0 >= 0 && s[l0] == s[r]))
                {
                    resut++;
                    l0--;
                    r++;
                }

                r = i + 1;
                while (r < s.Length && l1 >= 0 && s[l1] == s[r])
                {
                    resut++;
                    l1--;
                    r++;
                }
            }

            return resut + s.Length;
        }
    }
}
