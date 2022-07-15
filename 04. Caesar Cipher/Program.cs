using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word=Console.ReadLine();
            StringBuilder output=new StringBuilder();
            foreach (char ch in word)
            {
                int n = ch + 3;
                output.Append((char)n);
            }
            Console.WriteLine(output);
            
        }
    }
}
