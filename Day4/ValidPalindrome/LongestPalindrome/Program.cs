using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "babad";
            string s2 = "cbbd";
            Console.WriteLine(LongestPalindrome(s));
            Console.WriteLine(LongestPalindrome(s2));
            Console.ReadKey();
        }

        public static string LongestPalindrome(string s)
        {
            // Kiểm tra đầu vào
            if (s.Length < 2)
            {
                return s;
            }

            string result = s[0].ToString();
            for (int i = 0; i < s.Length; i++)
            {
                // Trường hợp aba[c]aba
                int l = i - 1;
                int r = i + 1;
                string temp1 = "";
                while (l >= 0 && r < s.Length &&
                    r - l < s.Length &&
                    s[l] == s[r])
                {
                    string temp2 = s.Substring(l, r - l + 1);
                    if (temp2.Length > temp1.Length)
                    {
                        temp1 = temp2;
                    }

                    l--;
                    r++;
                }

                //trường hợp sc[b]bca
                l = i;
                r = i + 1;
                while (l >= 0 && r < s.Length &&
                    r - l < s.Length &&
                    s[l] == s[r])
                {
                    string temp3 = s.Substring(l, r - l + 1);
                    if (temp3.Length > temp1.Length)
                    {
                        temp1 = temp3;
                    }

                    l--;
                    r++;
                }

                if (result.Length < temp1.Length)
                {
                    result = temp1;
                }
            }

            return result;
        }
    }
}
