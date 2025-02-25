namespace opg6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            bool isEqual = (num1 == num2);
            bool isNotEqual = (num1 != num2);
            bool isGreater = (num1 > num2);
            bool isLess = (num1 < num2);
            bool isGreaterOrEqual = (num1 >= num2);
            bool isLessOrEqual = (num1 <= num2);
            Console.WriteLine("is Equal: " + isEqual + " is Not Equal: " + isNotEqual + " is Greater: " + isGreater + " is less: " + isLess +
                " is Greater or Equal: " + isGreaterOrEqual + " is Less Or Equal: " + isLessOrEqual);
            Console.ReadKey();
        }
    }
}
