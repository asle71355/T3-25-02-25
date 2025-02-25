using opgave1;
using opgave2;
using opgave3;
using opgave4;
using opgave5;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Opgave 1");
        Opgave1.Alice();
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Opgave 2");
        Opgave2.Temp();
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Opgave 3");
        Opgave3.AliceBMI();
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Opgave 4");
        Opgave4.Sum();
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Opgave 5");
        Opgave5.Cirkel();
        Console.ReadKey();
        Console.Clear();

        Console.ReadKey();
    }
}