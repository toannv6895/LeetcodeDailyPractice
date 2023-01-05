using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumWindowSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "ADOBECODEBANC", t = "ABC";
            //string s = "ab", t = "a";
            //string s = "ab", t = "b";
            string s = "bbaa", t = "aba";
            Console.WriteLine(MinWindow(s, t));
            Console.ReadKey();
        }

        // This is my first solution => Failed
        public static string MinWindow(string s, string t)
        {
            if (s == null || t == null)
            {
                return "";
            }

            if (s == t)
            {
                return s;
            }

            if (s.Length < t.Length)
            {
                return "";
            }

            Queue<int> ints = new Queue<int>();
            StringBuilder stringBuilder= new StringBuilder();
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                stringBuilder.Append(s[i]);
                string temp = stringBuilder.ToString();

                if (t.Contains(s[i]))
                {
                    ints.Enqueue(i);
                }

                while ((IsContains(temp, t) || temp == t))
                {
                    if (result.Length > temp.Length || result == string.Empty)
                    {
                        result = temp;
                    }

                    //if (ints.Count >= 2)
                    //{
                    //    ints.Dequeue();
                    //}

                    if (ints.Any())
                    {
                        int index = ints.Dequeue();
                        temp = s.Substring(index, i - index + 1);
                        stringBuilder = new StringBuilder(temp);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return result;
        }

        private static bool IsContains(string a, string b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                if (!a.Contains(b[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
