using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //string[] strings = { "bdddddddddd", "bbbbbbbbbbc" };
            var result = GroupAnagrams(strings);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dic= new Dictionary<string, List<string>>();

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < strs.Length; i++)
            {
                string s = strs[i];
                int[] ints = new int[26];

                foreach (char c in s)
                {
                    ints[c - 'a']++;
                }

                foreach (var item in ints)
                {
                    stringBuilder.Append($"{item}, ");
                }

                string temp = stringBuilder.ToString();

                if (dic.ContainsKey(temp))
                {
                    dic[temp].Add(s);
                }
                else
                {
                    var value = new List<string>();
                    value.Add(s);
                    dic[temp] = value;
                }

                stringBuilder.Clear();
            }

            IList<IList<string>> result = new List<IList<string>>();

            foreach (var item in dic)
            {
                result.Add(item.Value);
            }

            return result;
        }
    }
}
