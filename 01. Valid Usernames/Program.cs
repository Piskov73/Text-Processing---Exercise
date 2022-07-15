using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userName = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var user in userName)
            {
                bool validUser = true;
                if (user.Length <= 3 || user.Length >=16)
                {
                    continue;
                }
                foreach (char item in user)
                {
                    if (char.IsLetter(item) || char.IsDigit(item) || item == '-' || item == '_')
                    {
                        continue;
                    }
                    else
                    {
                        validUser = false;
                        break;
                    }

                }
                if (validUser)
                {
                    Console.WriteLine(user);
                }
            }
        }
    }
}
