using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //abv>1>1>2>2asdasd
            string inputWord = Console.ReadLine();
            StringBuilder outpurText = new StringBuilder();
            int powarBoomb = 0;
            for (int i = 0; i < inputWord.Length; i++)
            {
                if (inputWord[i] == '>')
                {
                    powarBoomb += GetPowarBomb(inputWord[i + 1]);
                    outpurText.Append(inputWord[i]);
                }
                else
                {
                    if (powarBoomb > 0)
                    {
                        powarBoomb--;
                    }
                    else
                    {
                        outpurText.Append(inputWord[i]);
                    }
                }
            }
            Console.WriteLine(outpurText);
        }

        static int GetPowarBomb(char v)
        {
            return (int)v - 48;
        }
    }
}
