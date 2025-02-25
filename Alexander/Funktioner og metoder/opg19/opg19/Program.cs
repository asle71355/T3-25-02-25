namespace opg19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indtast sætning: ");
            string sætning = Console.ReadLine();
            Console.WriteLine("antal vokaler: " + antalVokaler(sætning));
            Console.ReadKey();
        }
        static int antalVokaler(string s)
        {
            int antalVokaler = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('a') || s[i].Equals('A') || s[i].Equals('e') || s[i].Equals('E') || s[i].Equals('i') || s[i].Equals('I') || s[i].Equals('o') || s[i].Equals('O')
                    || s[i].Equals('u') || s[i].Equals('U') || s[i].Equals('y') || s[i].Equals('Y') || s[i].Equals('æ') || s[i].Equals('Æ') || s[i].Equals('ø') || s[i].Equals('Ø')
                    || s[i].Equals('å') || s[i].Equals('Å'))
                {
                    antalVokaler++;
                }
            }
            return antalVokaler;
        }
    }
}
