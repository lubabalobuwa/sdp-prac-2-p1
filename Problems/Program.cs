using System;
using System.Collections;

namespace Problems
{
    public class Program
    {
        public string Prefix(string input)
        {
            if(input == String.Empty)
            {
                return "0,0:";
            }
			int counter =0;
            string output="";
            string[] words = input.Split();
            //List<string> Words = words.ToList<string>();
            foreach(string s in words)
            {
                if (s == ""){

                }
                else{
                    counter++;
                }

            }
            /* 
			for (int i=0; i<words.Length;i++)
			{
				if(words[i] == "")
				{
					//Words.RemoveAt(i);
				}
				else
				{
					counter++;
				}					
					
			}
			*/
			
            int lngth = input.Length;
            int NumberOfWords = counter;
            
            output = $"{lngth},{NumberOfWords}:{input}";

            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
