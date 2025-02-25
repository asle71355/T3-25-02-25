namespace opg21
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
                    float h = Convert.ToSingle(Console.ReadLine());
                    Console.Write("indtast bredde: ");
                    float b = Convert.ToSingle(Console.ReadLine());
                    Console.Write("indtast længde: ");
                    float i = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("rumfanget af din kube: " + Volume(h, b, i));
                    break;
                case 2:
                    Console.Write("indtast højde: ");
                    float højde = Convert.ToSingle(Console.ReadLine());
                    Console.Write("indtast radius: ");
                    float radius = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("rumfanget af din cylinder: " + Volume(højde, radius));
                    break;
            }
        }
        
        static float Volume(float h, float b, float l)
        {
            return l * b* h;
        }
        
        static float Volume(float h, float radius)
        {
            return float.Pi * (float)Math.Pow(radius, 2) * h;
        }
    }
}
