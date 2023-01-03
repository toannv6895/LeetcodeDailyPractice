using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "anagram", t = "nagaram";
            string s = "rat", t = "car";
            Console.WriteLine(IsAnagram(s, t));
            Console.ReadKey();
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic.Add(s[i], 1);
                }
                
            }

            for (int j = 0; j < t.Length; j++)
            {
                if (dic.ContainsKey(t[j]))
                {
                    if (dic[t[j]] > 1)
                    {
                        dic[t[j]]--;
                    }
                    else
                    {
                        dic.Remove(t[j]);
                    }
                }
            }

            if (dic.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
