namespace NicolaiApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menuValg;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu til at vælge dele af opgaven: ");
                Console.WriteLine("1. Del 1 - Variabler og datatyper");
                Console.WriteLine("2. Del 2 - Kontrolstrukturer");
                Console.WriteLine("3. Del 3 - Funtkioner og metoder");
                Console.WriteLine("4. Afslut menu");

                menuValg = Convert.ToInt32(Console.ReadLine());

                switch (menuValg)
                {
                    case 1:
                        Del1.Løsning();
                        break;
                    case 2:
                        Del2.Løsning();
                        break;
                    case 3:
                        Del3.Løsning();
                        break;
                }
            } while (menuValg != 4);

        }
    }

}
