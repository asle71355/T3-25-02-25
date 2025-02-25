using System.Security.Cryptography.X509Certificates;

namespace opg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 3)
            {
                Console.Write("(1) Celsius til Fahrenheit \n(2) Fahrenheit til Celsius\n(3) Exit\nvælg en mulighed: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        cTF();
                        break;
                    case 2:
                        fTC();
                        break;
                }
            }
            Console.ReadLine();
        }

        static void cTF()
        {
            Console.Write("indast grader i celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * (9.0 / 5.0) + 32;
            Console.WriteLine(celsius + "°C er " + fahrenheit + "°F");
        }

        static void fTC()
        {
            Console.Write("indast grader i fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * (5.0/9.0);
            Console.WriteLine(fahrenheit + "°F er " + celsius + "°C");
        }
    }
}
