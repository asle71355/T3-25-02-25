namespace opg18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indtast en sætning: ");
            string sætning = Console.ReadLine();
            Console.WriteLine(reverse(sætning));
            Console.ReadKey();
        }
        static string reverse(string s)
        {
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i];
            }
            return reverse;
        }
    }
}
