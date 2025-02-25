using System;

namespace opgave5
{
    public class Opgave5
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast radius på cirklen:");

            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            double circumf = 2 * Math.PI * radius;

            Console.WriteLine($"Area: {area}, Circumference: {circumf}");
        }
    }
}
