using System;

namespace opgave22
{
    public class Opgave22
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast et tal:");

            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast et andet tal:");

            int userInput2 = Convert.ToInt32(Console.ReadLine());

            ArealAfTrekant(ArealAfTrekant(userInput1, userInput2));
            ArealAfRektangel(ArealAfRektangel(userInput1, userInput2));

        }

        public static string ArealAfTrekant(int a, int b)
        {
            return $"Arealet af en trekant er {0.5 * a * b}.";
        }

        public static void ArealAfTrekant(string besked)
        {
            Console.WriteLine(besked);
        }

        public static string ArealAfRektangel(int a, int b)
        {
            return $"Arealet af en rektangel {a * b}.";
        }

        public static void ArealAfRektangel(string besked)
        {
            Console.WriteLine(besked);
        }
    }
}
