using System;

namespace opgave7
{
    public class Opgave7
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast et tal:");

            double userNum1 = Convert.ToDouble(Console.ReadLine());

            if (userNum1 > 0)
                Console.WriteLine("Tallet er positivt.");
            else if (userNum1 < 0)
                Console.WriteLine("Tallet er negativt.");
            else if (userNum1 == 0)
                Console.WriteLine("Tallet er 0.");
            else
                Console.WriteLine("Ugyldig værdi.");
        }
    }
}
