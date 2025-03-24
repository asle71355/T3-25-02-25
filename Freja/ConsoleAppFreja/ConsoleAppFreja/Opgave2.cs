using System;

namespace opgave2
{
    public class Opgave2
    {
        public static void Temp()
        {
            //Hvis du vil omregne 25°C til Fahrenheit: 25 * ( 9 / 5 ) + 32 = 77°F
            //Hvis du vil omregne 77°F til Celsius: ( 77 - 32 ) * ( 5 / 9 )  = ca. 25°C

            double fahrenheit;
            double celcius;

            Console.WriteLine("Indtast fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIndtast celcius: ");
            celcius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n{fahrenheit} °F is {(fahrenheit - 32) * 5 / 9} °C");
            Console.WriteLine($"{celcius} °C is {celcius * 9 / 5 + 32} °F");
        }
    }
}