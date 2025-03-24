using System;

public class Del3
{
	public static void Løsning()
	{
        int a = 3, b = 5;
        Console.WriteLine($"\n{a} + {b} = {Sum(a, b)}");

        string tekst = "Dette er en tekst";
        Console.WriteLine($"\nDen originale tekst: {tekst} \nDen omvendte tekst: {Reversetxt(tekst)}");


        string vokalTekst = "Denne tekst er bare for at tælle vokaler i";
        Console.WriteLine($"\nAntallet af vokaler i den følgende tekst:\n{vokalTekst}\nAntal vokaler: {Vokaler(vokalTekst)}");

        int circleRadius = 5;
        double firkantLængde = 5, firkantBredde = 5;
        Console.WriteLine($"\nFirkantens areal: {Areal(firkantLængde, firkantBredde):F2}");
        Console.WriteLine($"Cirklens areal: {Areal(circleRadius):F2}");

        int kubeHøjde = 5, kubeBredde = 3, kubeLængde = 5;
        int cylenderHøjde = 10, cylendeRadius = 3;
        Console.WriteLine($"\nKubens volume er = {Volume(kubeHøjde, kubeBredde, kubeLængde):F2}");
        Console.WriteLine($"Cylenderns volume er = {Volume(cylenderHøjde, cylendeRadius):F2}");

        int trekantHøjde = 6, grundlinje = 3;
        double rektangelLængde = 10, rektangelBredde = 4;
        Console.WriteLine($"\nTrekantens areal er = {Areal(trekantHøjde, grundlinje):F2}");
        Console.WriteLine($"Rektanglens areal er = {Areal(rektangelLængde, rektangelBredde):F2}");




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

    static double Volume(int a, int b, int c)
    {
        return a * b * c;
    }
    static double Volume(int a, int r)
    {
        double PI = 3.1415926535897931;
        return PI * Math.Pow(r, 2) * a;
    }

    static double Areal(int a, int b)
    {
        return 0.5 * a * b;
    }
}

