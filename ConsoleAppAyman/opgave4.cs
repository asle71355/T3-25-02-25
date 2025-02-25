using System;

namespace opgave4
{
    public class Opgave4
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast første tal:");

            double userNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast andet tal:");

            double userNum2 = Convert.ToDouble(Console.ReadLine());

            double sum = userNum1 + userNum2;
            double diff = userNum2 - userNum1;
            double product = userNum1 * userNum2;
            double quot = userNum1 / userNum2;
            double remain = userNum1 % userNum2;

            Console.WriteLine($"Sum: {sum}, Difference: {diff}, Product: {product}, Quotient: {quot}, Remainder: {remain}");

        }
    }
}
