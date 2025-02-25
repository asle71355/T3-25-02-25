using System;

namespace opgave15
{
    public class Opgave15
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast et tal:");

            int userInput = Convert.ToInt32(Console.ReadLine());
            int res = 0;

            for (int i = userInput; i > 0; i--)
                res += i;

            Console.WriteLine($"Sum af de første {userInput} tal er: {res}");
        }
    }
}
