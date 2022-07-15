using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            string wordFirst = words[0];
            string wordSecond = words[1];
            if (wordFirst.Length == wordSecond.Length)
            {
                for (int i = 0; i < wordFirst.Length; i++)
                {
                    sum += wordFirst[i] * wordSecond[i];
                }
            }
            else if (wordFirst.Length > wordSecond.Length)
            {
                for (int i = 0; i < wordSecond.Length; i++)
                {
                    sum += wordFirst[i] * wordSecond[i];
                }
                for (int i = wordSecond.Length; i < wordFirst.Length; i++)
                {
                    sum += wordFirst[i];
                }
            }
            else
            {
                for (int i = 0; i < wordFirst.Length; i++)
                {
                    sum += wordFirst[i] * wordSecond[i];
                }
                for (int i = wordFirst.Length ; i < wordSecond.Length; i++)
                {
                    sum += wordSecond[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
