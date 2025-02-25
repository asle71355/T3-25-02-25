using System;

namespace opgave21
{
    public class Opgave21
    {
        public static void Solution()
        {
            Console.WriteLine("Indtast et tal:");

            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast andet tal:");

            int userInput2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast trejde tal:");

            int userInput3 = Convert.ToInt32(Console.ReadLine());

            RumfangKube(RumfangKube(userInput1, userInput2, userInput3));
            RumfangCylinder(RumfangCylinder(userInput1, userInput2));

        }

        public static string RumfangKube(int a, int b, int c)
        {
            return $"Rumfang af kube er {a * b * c}.";
        }

        public static void RumfangKube(string besked)
        {
            Console.WriteLine(besked);
        }

        public static string RumfangCylinder(int a, int b)
        {
            return $"Rumfang af cylinder er {Math.PI * Math.Pow(a, 2) * b}.";
        }

        public static void RumfangCylinder(string besked)
        {
            Console.WriteLine(besked);
        }
    }
}
