using System;

namespace opgave3
{
    public class Opgave3
    {
        public static void BMI()
        {
            Console.WriteLine("Beregn BMI.");
            Console.WriteLine("Indtast vægt:");

            double userWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast højde:");

            double userHeight = Convert.ToDouble(Console.ReadLine());

            double userBMI = userWeight / Math.Pow(userHeight,2);

            Console.WriteLine($"Din bmi er {userBMI}");

        }
    }
}
