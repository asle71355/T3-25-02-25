using System;
using System.Linq;

namespace opgave19
{
    public class Opgave19
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast en string:");

            string? userInput = Console.ReadLine();

            Console.WriteLine($"Der er {AntalVokaler(userInput)} antal vokaler.");
        }

        public static int AntalVokaler(string userInput)
        {
            char[] vokaler = new char[]
            {
                'a', 'e', 'i', 'o', 'u', 'y', 'æ', 'ø', 'å',
                'A', 'E', 'I', 'O', 'U', 'Y', 'Æ', 'Ø',
            };

            int res = 0;
            for (int i = 0; i < userInput.Length; i++)
                if (vokaler.Contains(userInput[i]))
                    res++;

            return res;
        }
    }
}
