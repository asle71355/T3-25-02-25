using System;

namespace opgave4
{
    public class Opgave4
    {
        public static void Sum()
        {
            ///Aritmetiske operatører:
            // + (Addition): Lægger to tal sammen(f.eks.a +b)
            // - (Subtraktion): Trækker et tal fra et andet(f.eks.a -b)
            // * (Multiplikation): Ganger to tal(f.eks.a b)
            // / (Division): Dividerer et tal med et andet(f.eks.a / b)
            // % (Modulus): Finder resten ved division af to tal(f.eks.a % b)

            Console.WriteLine("Indtast tal 1: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIndtast tal 2: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double difference = num2 - num1;
            double product = num1 * num2;
            double quotient = num1 / num2;
            double remainder = num1 % num2;

            Console.WriteLine($"\nHer er resultatet:\nSum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");
        }
    }
}