using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputInt = Console.ReadLine();
            int multip = int.Parse(Console.ReadLine());
            if (multip == 0)
            {
                Console.WriteLine("0");

                return;               
            }
            StringBuilder intRevers = new StringBuilder();
            int flag = 0;
            for (int i = inputInt.Length - 1; i >= 0; i--)
            {
                //789
                int mul = GetInt(inputInt[i]);
                int x = mul * multip+flag;
                if (x < 10)
                {
                    intRevers.Append(x);
                    flag=0;
                }
                else
                {
                    int y = x %10;
                    intRevers.Append(y);
                    flag = x / 10;

                }

            }
            if(flag>0)
            {
                intRevers.Append(flag);
            }
           
            StringBuilder input = new StringBuilder();
            for (int i = intRevers.Length-1; i >=0 ; i--)
            {
                input.Append(intRevers[i]);
            }

            Console.WriteLine(input.ToString());
        }

        static int GetInt(char v)
        {
            return v - 48;
        }
    }
}
