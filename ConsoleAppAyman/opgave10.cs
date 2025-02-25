using System;

namespace opgave10
{
    public class Opgave10
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast et tal (1-7):");

            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lørdag");
                    break;
                case 7:
                    Console.WriteLine("Søndag");
                    break;
                default:
                    Console.WriteLine("Ugyldig værdi.");
                    break;
            }
        }
    }
}
