namespace opg22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) beregn volume af kube\n(2) beregn volume af cylinder\nvælg aktion: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            switch (tal)
            {
                case 1:
                    Console.Write("indtast højde: ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.Write("indtast grundlinjens længde: ");
                    double g = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("arealet af trekanten: " + Areal(h, g));
                    break;
                case 2:
                    Console.Write("indtast længden: ");
                    float l = Convert.ToSingle(Console.ReadLine());
                    Console.Write("indtast bredde: ");
                    float b = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("rumfanget af din cylinder: " + Areal(l, b));
                    break;
            }
        }

        static double Areal(double h, double g)
        {
            return 1/2 * h * g;
        }

        static float Areal(float l, float b)
        {
            return l * b;
        }
    }
}
