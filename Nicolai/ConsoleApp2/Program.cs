namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5;
            Console.WriteLine($"{a} + {b} = {Sum(a, b)}");

            string tekst = "Dette er en tekst";
            Console.WriteLine($"Den originale tekst: {tekst} \nDen omvendte tekst: {Reversetxt(tekst)}");


            string vokalTekst = "Denne tekst er bare for at tælle vokaler i";
            Console.WriteLine($"Antallet af vokaler i den følgende tekst:\n{vokalTekst}\nAntal vokaler: {Vokaler(vokalTekst)}");

            int circleRadius = 5;
            double firkantLængde = 5, firkantBredde = 10;
            Console.WriteLine($"Firkantens areal: {Areal(firkantLængde, firkantBredde)}");
            Console.WriteLine($"Cirklens areal: {Areal(circleRadius)}");




            Console.ReadLine();
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static string Reversetxt(string tekst)
        {
            return new string(tekst.Reverse().ToArray());
        }

        static int Vokaler(string vokalTekst)
        {
            string vokal = "aeiouyæøå";
            int vokalSum = 0;

            for (int i = 0; i < vokalTekst.Length; i++)
            {
                if (vokal.Contains(vokalTekst[i]))
                {
                    vokalSum++;
                }
            }
            return vokalSum;
        }

        static double Areal(double a, double b)
        {
            return a * b;
        }
        static double Areal(int r)
        {
            double PI = 3.1415926535897931;
            return (PI * Math.Pow(r, 2));
        }
    }

}
