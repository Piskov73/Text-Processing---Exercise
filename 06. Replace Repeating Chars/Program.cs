using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder outputWord= new StringBuilder();
            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    continue;
                }
                else
                {
                    outputWord.Append(word[i]);
                }
            }
            outputWord.Append(word[word.Length-1]);
            Console.WriteLine(outputWord);
        }
    }
}
