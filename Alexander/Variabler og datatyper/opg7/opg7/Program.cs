namespace opg7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indast tal: ");
            double tal = Convert.ToInt32(Console.ReadLine());
            if (tal < 0)
            {
                Console.WriteLine("negativt");
            }
            else if (tal == 0)
            {
                Console.WriteLine("tallet er nul");
            }
            else
            {
                Console.WriteLine("tallet er positivt");
            }
            Console.ReadKey();
        }
    }
}
