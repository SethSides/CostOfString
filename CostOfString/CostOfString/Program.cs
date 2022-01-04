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
            Console.WriteLine("Type any word to get the value.");

            //user input for word you want the value of
            var inputWord = Console.ReadLine();

            var cost = CostOfString(inputWord);

            //displays the user input and the "cost" of the given word.
            Console.WriteLine($"Cost of \"{inputWord}\" is : {cost}");


            Console.ReadKey();
        }

        public static int CostOfString(string s)
        {
            var total = 0;

            foreach (var c in s)
            {
                //checks to see if each character in the given string is a vowel
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    //if the character is a vowel, the total is incremented by 2
                    total += 2;
                }
                else
                {
                    //if the character is a vowel, the total is incremented by 1
                    total += 1;
                }
            }

            return total; //returns the sum of the value of the vowels and consonants
        }
    }
}
