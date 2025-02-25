using opgave1;
using opgave2;
using opgave3;
using opgave4;
using opgave5;
using opgave6;
using opgave7;
using opgave8;
using opgave9;
using opgave10;
using opgave11;
using opgave12;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Menu
1. Udskriv værdier på Alice.
2. Konvertere fra Celcius til Fahrenheit og fra Fahrenheit til Celcius.
3. Beregn BMI.
4. Grundlæggende matematiske operationer.
5. Beregn areal og omkreds af en cirkel.
6. Sammenlign to tal.
7. Tjek om et tal er negativt, positivt eller 0.
8. Kontrollere at en karakter er bestået
9. Tjek om et år er et skudår.
10. Udskriv en ugedag.
11. Udskriv en besked baseret på en måned.
12. Udskriv tallene fra 1 til 10.");


        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch(userChoice){
            case 1:
                Opgave1.Write();
                break;
            case 2:
                Opgave2.ConvertTemp();
                break;
            case 3:
                Opgave3.BMI();
                break;
            case 4:
                Opgave4.Solution();
                break;
            case 5:
                Opgave5.Solution();
                break;
            case 6:
                Opgave6.Solution();
                break;
            case 7:
                Opgave7.Solution();
                break;
            case 8:
                Opgave8.Solution();
                break;
            case 9:
                Opgave9.Solution();
                break;
            case 10:
                Opgave10.Solution();
                break;
            case 11:
                Opgave11.Solution();
                break;
            case 12:
                Opgave12.Solution();
                break;
            default:
                Console.WriteLine("Ugyldig værdi.");
                break;
        }

        Console.ReadLine();
    }
}
