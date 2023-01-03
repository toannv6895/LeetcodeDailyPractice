using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "()";
            Console.WriteLine(IsValid(s));
            s = "()[]{}";
            Console.WriteLine(IsValid(s));
            s = "(]";
            Console.WriteLine(IsValid(s));
            Console.ReadKey();
        }

        public static bool IsValid(string s)
        {
            if (s == null) { return false; }
            if (s.Length % 2 != 0)
            {
                return false;
            }

            var stack = new Stack<char>();

            for (int j = 0; j < s.Length; j++)
            {
                if (stack.Count > 0)
                {
                    var curr = stack.Peek();
                    if ((curr == '(' && s[j] == ')') ||
                        curr == '{' && s[j] == '}' ||
                        curr == '[' && s[j] == ']')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(s[j]);
                    }
                }
                else
                {
                    stack.Push(s[j]);
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
