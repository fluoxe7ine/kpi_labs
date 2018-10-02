using System;

namespace lab2_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Bignum_arithmetic ba1 = new Bignum_arithmetic("-128");
            Bignum_arithmetic ba2 = new Bignum_arithmetic("125");
            Bignum_arithmetic ba3 = ba1 + ba2;
            Console.WriteLine(ba3.bignum);
        }
    }
}
