namespace opg10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indtast et tal melle 1-7: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            switch (tal)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lørdag");
                    break;
                case 7:
                    Console.WriteLine("Søndag");
                    break;
            }
            Console.ReadKey();
        }
    }
}
