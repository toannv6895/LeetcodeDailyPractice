using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterReplacement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CharacterReplacement("ABAB",2));
            //Console.WriteLine(CharacterReplacement("ABAA", 0));
            Console.WriteLine(CharacterReplacement("ABBB", 2));
        }

        public static int CharacterReplacement(string s, int k)
        {
            if (s == null) return 0;

            if (s.Length < 2)
            {
                return s.Length;
            }

            int[] arr = new int[26];

            int maxCount = 0;
            int res = 0;
            int left = 0;
            for (int right = 0; right < s.Length; right++)
            {
                maxCount = Math.Max(maxCount, ++arr[s[right] - 'A']);
                while (right - left + 1 - maxCount > k)
                {
                    arr[s[left] - 'A']--;
                    left++;
                }
                res = Math.Max(res, right - left + 1);
            }

            return res;
        }
    }
}
