using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimetoBuyandSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(ints));
            Console.ReadKey();
        }

        public static int MaxProfit(int[] prices)
        {
            if (prices == null)
            {
                return 0;
            }

            int min = prices[0];
            int result = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                min = Math.Min(min, prices[i]);
                result = Math.Max(result, prices[i] - min);
            }

            return result;
        }
    }
}
