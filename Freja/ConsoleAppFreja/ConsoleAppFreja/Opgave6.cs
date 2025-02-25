using System;

namespace opgave6
{
    public class Opgave6
    {
        public static void IsSomething()
        {
            ///Sammenligningsoperatører:
            //== (Lighed): Tjekker om to værdier er ens(f.eks.a == b)
            //!= (Ulighed): Tjekker om to værdier er forskellige(f.eks.a != b)
            //> (Større end): Tjekker om en værdi er større end en anden(f.eks.a > b)
            //< (Mindre end): Tjekker om en værdi er mindre end en anden(f.eks.a < b)
            //>= (Større end eller lig med): Tjekker om en værdi er større end eller lig med en anden(f.eks.a >= b)
            //<= (Mindre end eller lig med): Tjekker om en værdi er mindre end eller lig med en anden(f.eks.a <= b)

            Console.WriteLine("Indtast tal 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIndtast tal 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            bool equalTo = num1 == num2;
            bool notEqualTo = num1 != num2;
            bool greaterThan = num1 > num2;
            bool lessThan = num1 < num2;
            bool greaterOrEqual = num1 >= num2;
            bool lessThanOrEqual = num1 <= num2;

            Console.WriteLine(
                $"\n{num1} is equal to {num2}: {equalTo}" +
                $"\n{num1} is not equal to {num2}: {notEqualTo}" +
                $"\n{num1} is greater than {num2}: {greaterThan}" +
                $"\n{num1} is less {num2}: {lessThan} " +
                $"\n{num1} is greater or equal to {num2}: {greaterOrEqual} " +
                $"\n{num1} is less or greater than {num2}: {lessThanOrEqual}");
        }
    }
}