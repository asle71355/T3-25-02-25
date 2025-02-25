using System;

namespace opgave6
{
    public class Opgave6
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast første tal:");

            double userNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast andet tal:");

            double userNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Is Equal: {userNum1==userNum2}, Is Not Equal: {userNum1 != userNum2}, Is Greater: {userNum1 > userNum2}, Is Less: {userNum1 < userNum2}, Is Greater Or Equal: {userNum1 >= userNum2}, Is Less Or Equal: {userNum1 <= userNum2}");

        }
    }
}
