using System;

namespace opgave9
{
    public class Opgave9
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast et årstal:");

            int userYear = Convert.ToInt32(Console.ReadLine());

            if (userYear % 4 == 0)
            {
                if(userYear % 100 == 0)
                {
                    if (userYear % 400 == 0)
                        Console.WriteLine("Det er et skudår.");
                    else
                        Console.WriteLine("Det er ikke et skudår.");
                }
                else
                    Console.WriteLine("Det er et skudår.");
            }
            else
                Console.WriteLine("Det er ikke et skudår.");
        }
    }
}
