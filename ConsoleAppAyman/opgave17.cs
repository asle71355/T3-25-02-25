using System;

namespace opgave17
{
    public class Opgave17
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast et tal:");

            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast et andet tal:");

            int userInput2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(PlusseToTal(userInput1, userInput2));
        }

        public static int PlusseToTal(int a, int b)
        {
            return a + b;
        }
    }
}
