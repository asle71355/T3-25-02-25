namespace opg20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("(1) beregn areal af firkant\n(2) beregn areal af cirkel\nvælg en aktion: ");
            int tal = Convert.ToInt32(Console.ReadLine());

            switch (tal)
            {
                case 1:
                    Console.WriteLine("Indtast hæjde: ");
                    float højde = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("indtast sidelængde: ");
                    float sidelængde = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("arealet af firkanten er: " + Area(højde, sidelængde));
                    break;
                case 2:
                    Console.WriteLine("Indtast radius af cirklen: ");
                    float radius = Convert.ToSingle(Console.ReadLine()); 
                    Console.WriteLine("arealet af cirklen er: " + Area(radius));
                    break;
            }
        }
        static double Area(double x, double y)
        {
            return x * y;
        }
        static float Area(float r)
        {
            return float.Pi * (float)Math.Pow(r, 2);
        }
    }
}
