using System;

namespace opgave22
{
    public class Opgave22
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast hvilken form det er (trekant eller rektangel):");

            string userForm = Console.ReadLine();

            if (userForm.ToLower() == "trekant")
            {
                Console.WriteLine("Indtast mål på grundlinje:");

                int userInput1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Indtast mål på højde:");

                int userInput2 = Convert.ToInt32(Console.ReadLine());

                ArealAfTrekant(ArealAfTrekant(userInput1, userInput2));
            } 
            else if (userForm.ToLower() == "rektangel")
            {
                Console.WriteLine("Indtast mål på længde:");

                int userInput1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Indtast mål på bredde:");

                int userInput2 = Convert.ToInt32(Console.ReadLine());

                ArealAfRektangel(ArealAfRektangel(userInput1, userInput2));
            }
            else
            {
                Console.WriteLine("Ugyldig værdi.")
            }

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
