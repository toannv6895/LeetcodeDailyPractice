using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterReplacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CharacterReplacement("ABAB",2));
            //Console.WriteLine(CharacterReplacement("ABAA", 0));
            Console.WriteLine(CharacterReplacement("ABBB", 2));
        }

        //I'm wrong with this solution
        public static int CharacterReplacement(string s, int k)
        {
            //Check validate
            if (s == null) return 0;
            if (s.Length < 2) return s.Length;

            int l = 0;
            int r = 1;
            int curr = 1;
            int max = 0;
            int k1 = k;

            while (l < r && r < s.Length)
            {
                if (s[l] != s[r])
                {
                    if (k > 0)
                    {
                        curr++;
                        r++;
                        k--;
                    }
                    else
                    {
                        curr = 1;
                        k = k1;
                        l++;
                        r = l + 1;
                    }

                    while (r < s.Length - 1 && s[r] == s[r + 1])
                    {
                        curr++;
                        r++;
                    }
                }
                else
                {
                    curr++;
                    r++;
                }

                max = Math.Max(max, curr);
            }

            return max;
        }
    }
}
