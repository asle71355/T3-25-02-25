namespace opg8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indtast karakter(A, B, C, D eller F): ");
            char karakter = Console.ReadLine()[0];
            Console.WriteLine(beståetEllerEj(karakter));
            Console.ReadKey();
        }
        static string beståetEllerEj(char karakter)
        {
            if (karakter.Equals('A') || karakter.Equals('B') || karakter.Equals('C'))
            {
                return "Bestået";
            }
            else
            {
                return "Ikke bestået";
            }
        }
    }
}
