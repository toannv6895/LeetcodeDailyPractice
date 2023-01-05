using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumWindowSubstring2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "ADOBECODEBANC", t = "ABC";
            //string s = "ab", t = "a";
            //string s = "ab", t = "b";
            //string s = "bbaa", t = "aba";
            string s = "ab", t = "A";
            Console.WriteLine(MinWindow(s, t));
            Console.ReadKey();
        }

        public static string MinWindow(string s, string t)
        {
            if (s == null || t == null)
            {
                return "";
            }

            if (s.Length < 2)
            {
                if (s == t)
                {
                    return s;
                }
                else
                {
                    return "";
                }
            }

            if (s.Length < t.Length)
            {
                return "";
            }

            //Dùng để chứa danh sách index các phần tử đã được tìm thấy
            Queue<int> ints = new Queue<int>();
            int l = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            Dictionary<char, int> mapCheck = new Dictionary<char, int>();
            int min = -1, max = -1;

            for (int i = 0; i < t.Length; i++)
            {      
                if (!mapCheck.ContainsKey(t[i]))
                {

                    mapCheck[t[i]] = 1;
                }
                else
                {
                    mapCheck[t[i]]++;
                }

                map[t[i]] = 0;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                    ints.Enqueue(i);
                }

                while (CompareDictionary(map, mapCheck))
                {
                    int min_temp = ints.Dequeue();
                    int max_temp = i;

                    if (max_temp - min_temp < max - min || (min < 0 && max < 0))
                    {
                        max = max_temp;
                        min = min_temp;
                    }

                    map[s[min_temp]]--;
                }
            }

            if (min == -1 && max == -1)
            {
                return "";
            }

            return s.Substring(Math.Max(min,0), Math.Max(max - min + 1,0));
        }

        private static bool CompareDictionary(Dictionary<char, int> a, Dictionary<char, int> b)
        {
            foreach (var item in a.Keys)
            {
                if (a[item] < b[item])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
