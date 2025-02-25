using System;

public class Del2
{
	public static void Løsning()
	{
        Console.Write("Skriv et tal: ");
        int tal = Convert.ToInt32(Console.ReadLine());

        if (tal > 0)
        {
            Console.WriteLine($"Dit tal {tal} er positivt");
        }
        else if (tal < 0)
        {
            Console.WriteLine($"Dit tal {tal} er negativt");
        }


        Console.Write("Indtast din karakter: A, B, C, D, F: ");
        char karakter = Console.ReadLine().ToUpper()[0];

        if (ErBestået(karakter))
        {
            Console.WriteLine("Du er bestået");
        }
        else
        {
            Console.WriteLine("Du er ikke bestået");
        }


        Console.Write("\nIndtast år for at tjekke om det er skudår: ");
        int år = Convert.ToInt32(Console.ReadLine());

        bool skudår = (år % 4 == 0 && (år % 100 != 0 || år % 400 == 0));

        // år % 4 == 0: Året SKAL være deleligt med 4.
        // år % 100 != 0: Tjekker om året ikke er deleligt med 100.
        // år % 400 == 0: Hvis året er deleligt med 400, er det et skudår

        if (skudår)
        {
            Console.WriteLine("Dit år er skudår");
        }
        else
        {
            Console.WriteLine("Dit år er ikke skudår");
        }

        Console.Write("\nWhat number day is it currently of the week? From 1 - 7 ");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("It's monday");
                break;
            case 2:
                Console.WriteLine("It's tuesday");
                break;
            case 3:
                Console.WriteLine("It's wednesday");
                break;
            case 4:
                Console.WriteLine("It's thursday");
                break;
            case 5:
                Console.WriteLine("It's friday");
                break;
            case 6:
                Console.WriteLine("It's saturday");
                break;
            case 7:
                Console.WriteLine("It's sunday");
                break;
            default:
                Console.WriteLine("Please select valid date");
                break;
        }



        string[] månedBesked = new string[12]
        {
                "Januar - Vinteren er kold",
                "Februar - Korteste måned!",
                "Marts - Endelig forår!",
                "April - Påsketid!",
                "Maj - Snart sommer!",
                "Juni - Endelig sommer!",
                "Juli - Rart med sommerferie og det gode vejr",
                "August - Sommeren er virkelig varm nu",
                "September - Skolestart igen",
                "Oktober - Man kan godt mærke det er efterår nu..",
                "November - Det er virkelig ved at blive koldt, snart vinter nu..",
                "December - Nu er det vinter, men det er snart jul"
        };

        Console.Write("\nHvilken måned vil du vælge? Fra 1 - 12: ");
        int month = Convert.ToInt32(Console.ReadLine());

        if (month >= 1 && month <= 12)
        {
            string besked = månedBesked[month - 1];
            Console.WriteLine($"Din valgte måned: {besked}");
        }


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i}");
        }

        int n = 1;
        while (n <= 10)
        {
            Console.WriteLine($"{n++}");
        }

        int a = 1;
        do
        {
            Console.Write($"{a++}\n");
        } while (a <= 10);


        Console.Write("\nIndtast et tal du vil plusse med alle mindre tal indtil du kommer til dette tal: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i <= number; i++)
        {
            sum += i;
        }
        Console.WriteLine($"The sum of {number} = {sum}");

        Console.Write("\nWhat do you wish to know the factor of?");
        int numFactor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The factor of {numFactor}! = {Factor(numFactor)}");



        Console.ReadLine();
    }


    static int Factor(int numFactor)
    {
        if (numFactor == 1)
        {
            return 1;
        }
        else
        {
            return (numFactor * Factor(numFactor - 1));
        }
    }



    static bool ErBestået(char karakter)
    {
        return karakter == 'A' || karakter == 'B' || karakter == 'C';
    }
}

