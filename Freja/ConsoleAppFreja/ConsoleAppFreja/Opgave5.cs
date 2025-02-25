using System;

namespace opgave5
{
    public class Opgave5
    {
        public static void Cirkel()
        {
            ///Aritmetiske operatører:
            // + (Addition): Lægger to tal sammen(f.eks.a +b)
            // - (Subtraktion): Trækker et tal fra et andet(f.eks.a -b)
            // * (Multiplikation): Ganger to tal(f.eks.a b)
            // / (Division): Dividerer et tal med et andet(f.eks.a / b)
            // % (Modulus): Finder resten ved division af to tal(f.eks.a % b)

            double pi = Math.PI;
            Console.WriteLine("Indtast din cirkels radius: ");

            double r = Convert.ToDouble(Console.ReadLine());

            double areal = pi * (r * r);
            double omkreds = 2 * pi * r;

            Console.WriteLine($"\nHer er resultatet:\nAreal: {areal}, Omkreds: {omkreds}");

            Console.ReadKey();
        }
    }
}