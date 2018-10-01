using System;

namespace lab2_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction("18/3");
            Fraction f2 = new Fraction("-8/2");
            Fraction f3 = f2.Clone() as Fraction;
            Console.WriteLine(f1 != f2);
            Console.WriteLine(f1 == f2);
            Fraction f4 = f1 + f2 - 2 * f3 + 12 / f1;
            Console.WriteLine(f4.fract_value);
        }
    }
}
