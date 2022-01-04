using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type any word to get the value");

            var inputWord = Console.ReadLine();

            var cost = CostOfString(inputWord);
            Console.WriteLine($"Cost of {inputWord} is : {cost}");
            Console.ReadKey();
        }

        public static int CostOfString(string s)
        {
            var total = 0;

            foreach (var c in s)
            {
                if (c == 'a' || c == 'e' || c == 'u' || c == 'o' || c == 'u')
                {
                    total += 2;
                }
                else
                {
                    total += 1;
                }
            }

            return total;
        }
    }
}
