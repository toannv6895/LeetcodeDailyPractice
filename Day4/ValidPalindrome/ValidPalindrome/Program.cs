using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "A man, a plan, a canal: Panama";
            string s = "A.";
            Console.WriteLine(IsPalindrome(s));
            Console.ReadKey();
        }

        public static bool IsPalindrome(string s)
        {
            if (s == null) { return false; }

            var s2 = System.Text.RegularExpressions.Regex.Replace(s, "[^a-zA-Z0-9]+", "").ToLower();

            int len = s2.Length;
            int l = 0;

            while (l <= len - l - 1)
            {
                var left = s2[l];
                var right = s2[len - l - 1];
                if (!left.Equals(right))
                {
                    return false;
                }
                l++;
            }

            return true;
        }
    }
}
