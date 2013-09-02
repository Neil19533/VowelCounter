using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCounter
{
    class Program
    {
        static Dictionary<char, int> Vowels = new Dictionary<char, int>() { { 'a', 0 }, { 'e', 0 }, { 'i', 0 }, { 'o', 0 }, { 'u', 0 } };

        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("---------Vowel Counter------------------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Enter text to check vowel content");
            string inputtext = Console.ReadLine();


            ParseVowelinfo(inputtext);

            String Stats = GetStats(Vowels);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(Stats);

            Console.ReadLine();

        }

        private static string GetStats(Dictionary<char, int> Vowels)
        {
            StringBuilder Stats = new StringBuilder();

            Stats.AppendLine("------Vowel Contents------");

            foreach (var Vowel in Vowels)
            {
                if (Vowel.Value > 0)
                {
                    Stats.AppendLine("Vowel: " + Vowel.Key + " Count: " + Vowel.Value);
                }
            }


            return Stats.ToString();
        }

        private static void ParseVowelinfo(string inputtext)
        {
            foreach (char Letter in inputtext)
            {
                if (Vowels.ContainsKey(Letter))
                {
                    Vowels[Letter] += 1;
                }
            }
        }
    }
}
