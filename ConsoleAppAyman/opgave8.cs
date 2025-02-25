using System;

namespace opgave8
{
    public class Opgave8
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast en karakter (A, B, C, D eller F:");

            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "A":
                case "B":
                case "C":
                case "D":
                    Console.WriteLine("Bestået");
                    break;
                case "F":
                    Console.WriteLine("Ikke bestået.");
                    break;
                default:
                    Console.WriteLine("Ugyldig værdi.");
                    break;
            }
        }
    }
}
