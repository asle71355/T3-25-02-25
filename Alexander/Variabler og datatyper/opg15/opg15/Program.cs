namespace opg15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tal = 10;
            int sum = 0;
            for (int i = 1; i <= tal; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum of the first " + tal + " numbers: " + sum);
        }
    }
}
