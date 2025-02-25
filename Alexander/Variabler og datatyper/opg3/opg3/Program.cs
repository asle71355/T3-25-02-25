namespace opg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Beregn BMI\nindtast vægt: ");
            double vægt = Convert.ToDouble(Console.ReadLine());
            Console.Write("indtast højde i meter: ");
            double højde = Convert.ToDouble(Console.ReadLine());
            double BMI = vægt / Math.Pow(højde, 2) ;
            Console.WriteLine(BMI);
            if (BMI < 18.5)
            {
                Console.WriteLine("Undervægtig");
            }
            else if (18.5 <= BMI && BMI  <= 24.9)
                {
                Console.WriteLine("Normalvægt");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine("Overvægtig");
            }
            else
            {
                Console.WriteLine("Fedme");
            }
            Console.ReadKey();
        }
    }
}
