namespace opg9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indtast år: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine(year + " er et skudår");
            }
            else
            {
                Console.WriteLine(year + " er ikke et skudår");
            }
            Console.ReadKey();
        }
    }
}
