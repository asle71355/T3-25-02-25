using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int age = 25;
        float height = 1.75f;
        double weight = 70.5;
        char initial = 'A';
        string name = "Alice";
        bool isStudent = true;

        Console.WriteLine($"Age: {age}, Height: {height}, Weight: {weight}, Initial: {initial}, Name: {name}, Is Student: {isStudent}");

        Console.ReadKey();
    }
}
