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
using opgave13;
using opgave14;
using opgave15;
using opgave16;
using opgave17;
using opgave18;
using opgave19;
using opgave20;
using opgave21;
using opgave22;

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
12. Udskriv tallene fra 1 til 10 (for-loop).
13. Udskriv tallene fra 1 til 10 (while-loop).
14. Udskriv tallene fra 1 til 10 (do-while-loop).
15. Udskriv sum af alle tal, fra 0 til valgt tal.
16. Udskriv fakultet af et tal.
17. Plusse to tal via metode med parametre og returntype
18. Returnere en omvendt string
19. Tæl vokaler i en string
20. Beregn areal af firkant og cirkel ved at overloade metoder
21. Beregn rumfang af en kube og cylinder ved at overloade metode
22. Bregn areal af en trekant og en rektangel ved at overloade metode");


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
            case 13:
                Opgave13.Solution();
                break;
            case 14:
                Opgave14.Solution();
                break;
            case 15:
                Opgave15.Solution();
                break;
            case 16:
                Opgave16.Solution();
                break;
            case 17:
                Opgave17.Solution();
                break;
            case 18:
                Opgave18.Solution();
                break;
            case 19:
                Opgave19.Solution();
                break;
            case 20:
                Opgave20.Solution();
                break;
            case 21:
                Opgave21.Solution();
                break;
            case 22:
                Opgave22.Solution();
                break;
            default:
                Console.WriteLine("Ugyldig værdi.");
                break;
        }

        Console.ReadLine();
    }
}
