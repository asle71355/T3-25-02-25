using System;

namespace opgave3
{
    public class Opgave3
    {
        public static void AliceBMI()
        {
            //BMI = vægten / højden ^ 2

            Console.WriteLine("Indtast din vægt: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast højde din: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Din BMI er " + weight / (height * height));

            Console.ReadKey();
        }
    }
}
