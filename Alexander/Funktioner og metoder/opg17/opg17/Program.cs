namespace opg17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("intast tal 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("intast tal 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("summen: " + sum(num1, num2));

        }
        static double sum(double num1, double num2)
        {
            return num1 + num2;
        }
        
    }
}
