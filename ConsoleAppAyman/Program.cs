using opgave1;
using opgave2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Menu
1. Udskriv værdier på Alice.
2. Konvertere fra Celcius til Fahrenheit og fra Fahrenheit til Celcius.");


        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch(userChoice){
            case 1:
                Opgave1.Write();
                break;
            case 2:
                Opgave2.ConvertTemp();
                break;
            default:
                Console.WriteLine("Ugyldig værdi.");
                break;
        }

        Console.ReadLine();
    }
}
