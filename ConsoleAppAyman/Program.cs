using opgave1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Menu
1. Udskriv værdier på Alice.");


        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch(userChoice){
            case 1:
                Opgave1.Write();
                break;
            default:
                Console.WriteLine("Ugyldig værdi.");
                break;
        }

        Console.ReadLine();
    }
}
