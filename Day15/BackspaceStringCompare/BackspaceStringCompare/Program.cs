using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackspaceStringCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "ab#c", t = "ad#c";
            //string s = "ab##", t = "c#d#";
            //string s ="a##c", t ="#a#c";
            string s = "y#fo##f", t = "y#f#o##f";
            Console.WriteLine(BackspaceCompare(s,t));
            Console.ReadLine();
        }

        public static bool BackspaceCompare(string s, string t)
        {
            if (s == null || t == null)
            {
                return false;
            }

            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    if (stack1.Any())
                    {
                        stack1.Pop();
                    }
                }
                else
                {
                    stack1.Push(s[i]);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == '#')
                {
                    if (stack2.Any())
                    {
                        stack2.Pop();
                    }
                }
                else
                {
                    stack2.Push(t[i]);
                }
            }

            if (stack1.Count != stack2.Count)
            {
                return false;
            }

            while (stack1.Any() && stack2.Any())
            {
                if (stack1.Pop() != stack2.Pop())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
