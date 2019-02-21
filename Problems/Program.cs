using System;

namespace Problems
{
    public class Program
    {
        public string Prefix(string input)
        {
            string output="";
            string[] words = input.Split();
            int lngth = 0;
            int NumberOfWords = words.Length;
            foreach(char c in input )
            {
                lngth++;
            }
            output = $"{lngth},{NumberOfWords}:{input}";

            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
