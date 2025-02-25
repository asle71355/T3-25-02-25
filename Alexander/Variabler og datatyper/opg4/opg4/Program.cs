namespace opg4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;
            int sum = num1 + num2;
            int dif = num1 - num2;
            int pro = num1 * num2;
            int quo = num1 / num2;
            int rem = num1 % num2;
            Console.WriteLine("sum: " + sum + ", Difference: " + dif + ", Product: " + pro + ", Quotient: " + quo + ", Remainder: " + rem);
            Console.ReadKey();
        }
    }
}
