using System;

namespace ExtractAllPossibleSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert text below!");
            string input = Console.ReadLine();
            string output = GetSubstrings(input);
            Console.WriteLine(output);
        }

        public static string GetSubstrings(string InputText)
        {
            string substring = "";
            InputText = InputText.Trim();
            for (int i = 0; i < InputText.Length; i++)
            {
                for (int j = 0; j <= InputText.Length -i; j++)
                {
                   substring = InputText.Substring(j,i);
                }
            }
            return substring;
        }
    }
}
