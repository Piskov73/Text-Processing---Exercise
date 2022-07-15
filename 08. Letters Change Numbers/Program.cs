using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal output =GetTotalSum (input);
            Console.WriteLine($"{output:f2}");
          
          
        }

        
        static decimal GetTotalSum(string[] input)
        {
            decimal sum = 0;
            foreach (var text in input)
            {
                decimal sumTemp = 0;
                char firstCh = text[0];
                char lastCh = text[text.Length - 1];
                string numbString = text.Remove(0, 1);
                numbString = numbString.Remove(numbString.Length - 1, 1);
                decimal number = decimal.Parse(numbString);
                if (firstCh >= 'A' && firstCh <= 'Z')
                {
                    sumTemp += number / (firstCh - 64);
                }
                else
                {
                    sumTemp += number * (firstCh - 96);
                }
                if (lastCh >= 'A' && lastCh <= 'Z')
                {
                    sumTemp -=  (lastCh - 64);
                }
                else
                {
                    sumTemp +=  (lastCh - 96);
                }
                sum += sumTemp;

            }
            return sum;
        }
    }
}
