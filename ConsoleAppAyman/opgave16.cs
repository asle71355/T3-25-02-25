using System;

namespace opgave16
{
    public class Opgave16
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast et tal:");

            int userInput = Convert.ToInt32(Console.ReadLine());
            int res = 1;

            for (int i = userInput; i > 0; i--)
                res *= i;

            Console.WriteLine($"Sum af fakultet af {userInput} er: {res}");
        }
    }
}
