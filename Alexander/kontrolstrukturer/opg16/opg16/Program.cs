using System.Diagnostics.CodeAnalysis;

namespace opg16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indtast et positivt nummer: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            int sum = tal;
            for (int i = tal - 1; i >= 1; i--)
            {
                sum *= i;
            }
            Console.WriteLine("fakultetstallet: " + sum);
        }
    }
}
