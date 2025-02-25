using System;

namespace opgave2
{
    public class Opgave2
    {
        public static void ConvertTemp()
        {
            Console.WriteLine(@"Konvertere temperatur: 
1. Fra Celcius til Fahrenheit.
2. Fra Fahrenheit til Celcius.");

            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice != 1 && userChoice != 2)
            {
                Console.WriteLine("Ugyldigt valg.");
                return;
            }

            Console.WriteLine("Indtast værdi:");

            double userTemp = Convert.ToDouble(Console.ReadLine());

            if(userChoice == 1)
            {
                Console.WriteLine($"{userTemp} Celcius er {userTemp * 9 / 5 + 32} Fahrenheit.");
            }
            else if (userChoice == 2)
            {
                Console.WriteLine($"{userTemp} Fahrenheit er {(userTemp - 32) * 5 / 9} Fahrenheit.");
            }
        }
    }
}
