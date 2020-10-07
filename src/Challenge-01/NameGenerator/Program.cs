using System;
using System.Text;

namespace NameGenerator
{
    public static class Program
    {
        private static readonly string[] Consonants =
        {
            "b",
            "c",
            "d",
            "f",
            "g",
            "h",
            "j",
            "k",
            "l",
            "m",
            "n",
            "p",
            "q",
            "r",
            "s",
            "t",
            "v",
            "w",
            "x",
            "y",
            "z"
        };

        private static readonly string[] Vowels =
        {
            "a",
            "e",
            "i",
            "o",
            "u",
            "y"
        };

        private static readonly string[] Diphthongs =
        {
            "ow",
            "ou",
            "ie",
            "igh",
            "ay",
            "oi",
            "oo",
            "ea",
            "eer",
            "air",
            "ure"
        };

        private static void Main()
        {
            do
            {
                string name = GenerateName();

                Console.WriteLine("Hello: " + name);
                Console.WriteLine("Try again? (y/n)");
            } while (Console.ReadLine()?.StartsWith("y") ?? false);
        }

        private static string GenerateName()
        {
            var random = new Random();
            var nameBuilder = new StringBuilder(random.Pick(Consonants).ToUpper());

            do
            {
                nameBuilder.Append(random.Pick(random.Pick(Vowels, Diphthongs, Consonants)));
            } while (random.NextBool());

            return nameBuilder.ToString();
        }
    }
}