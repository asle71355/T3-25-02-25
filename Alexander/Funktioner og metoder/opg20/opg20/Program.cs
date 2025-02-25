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
                    Console.WriteLine("arealet af firkanten er: " + firkantArea(højde, sidelængde));
                    break;
                case 2:
                    Console.WriteLine("Indtast radius af cirklen: ");
                    float radius = Convert.ToSingle(Console.ReadLine()); 
                    Console.WriteLine("arealet af cirklen er: " + cirkelArea(radius));
                    break;
            }
        }
        static double firkantArea(double x, double y)
        {
            return x * y;
        }
        static float cirkelArea(float r)
        {
            return float.Pi * (float)Math.Pow(r, 2);
        }
    }
}
