using System;

namespace opgave3
{
    public class Opgave3
    {
        public static void AliceBMI()
        {
            //BMI = v�gten / h�jden ^ 2

            Console.WriteLine("Indtast din v�gt: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast h�jde din: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Din BMI er " + weight / (height * height));

            Console.ReadKey();
        }
    }
}
