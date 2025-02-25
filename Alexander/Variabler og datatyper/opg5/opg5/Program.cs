namespace opg5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double diameter = radius * 2;
            float area = float.Pi * (float)Math.Pow(radius, 2);
            float cir = float.Pi * (float)diameter;

            Console.WriteLine("Area: " + area + " Circumfernce: " + cir);
            Console.ReadKey();
        }
    }
}
