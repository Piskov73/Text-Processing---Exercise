using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);
            string[] outputAraay = input[input.Length - 1].Split('.', StringSplitOptions.RemoveEmptyEntries);
            // File name: Template
            //File extension: pptx
            Console.WriteLine($"File name: {outputAraay[0]}");
            Console.WriteLine($"File extension: {outputAraay[1]}");


        }
    }
}
