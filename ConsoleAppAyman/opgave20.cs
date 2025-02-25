using System;

namespace opgave20
{
    public class Opgave20
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast et tal:");

            int userInput = Convert.ToInt32(Console.ReadLine());

            ArealAfFirkant(ArealAfFirkant(userInput));
            ArealAfCirkel(ArealAfCirkel(userInput));

        }

        public static string ArealAfFirkant(int a)
        {
            return $"Arealet af en firkant er {a * a}.";
        }

        public static void ArealAfFirkant(string besked)
        {
            Console.WriteLine(besked);
        }

        public static string ArealAfCirkel(int a)
        {
            return $"Arealet af en cirkel er {Math.PI * Math.Pow(a, 2)}.";
        }

        public static void ArealAfCirkel(string besked)
        {
            Console.WriteLine(besked);
        }
    }
}
