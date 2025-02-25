using System;

public class Del1
{
    public static void Løsning()
    {
        int age = 25;
        double height = 1.75;
        double weight = 70.5;
        char intitial = 'A';
        string name = "Alice";
        bool isStudent = true;
        Console.WriteLine($"Age: {age}, Height: {height}, Weight: {weight}, Intitial: {intitial}, Name: {name}, Is student: {isStudent}");


        Console.Write("\nHvor mange grader fra celsius vil du konvertere til fahrenheit? ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Dit resultat er: {celsius * 1.8 + 32}");

        Console.Write("\nHvor mange grader fra fahrenheit vil du konvertere til celsius? ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nDit resultat er: {(fahrenheit - 32) * 0.5556}\");\r\n");


        Console.WriteLine("Enter for at fortsætte...");
        Console.ReadLine();

        Console.WriteLine($"Din BMI er: {weight} / {height}");

        Console.WriteLine($"Sum: {5 + 5}, Difference: {10 - 5}, Product: {10 * 5}, Division: {10 / 2}, Modulus: {10 % 3}");

        double PI = 3.1415926535897931;

        Console.Write("\nIndskriv areal af cirkel: ");
        double area = Convert.ToDouble(Console.ReadLine());
        Console.Write("Indskriv radius af cirkel: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Din omkreds er: {2 * PI * radius}");
        Console.WriteLine($"Dit areal er: {PI * Math.Pow(radius, 2)}");

        bool isEqual = (5 == 5);
        bool isNotEqual = (5 != 3); // Tjekker om forskellige
        bool isGreater = (5 > 4); // greater
        bool isLess = (5 < 4); // less
        bool isGreaterOrEqual = (5 >= 5);
        bool isLessOrEqual = (5 <= 4);

        Console.WriteLine($"Is equal: {isEqual}, is not equal: {isNotEqual}, is greater: {isGreater}, is less: {isLess}, is greater or equal: {isGreaterOrEqual}, is less or equal: {isLessOrEqual}");

    }
}

