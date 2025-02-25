using System;
using System.Linq;

namespace opgave18
{
    public class Opgave18
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast en string:");

            string? userInput = Console.ReadLine();

            Console.WriteLine(OmvendtString(userInput));
        }

        public static string OmvendtString(string userInput)
        {
            return new string(userInput.Reverse().ToArray());
        }
    }
}
