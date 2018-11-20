using System;
using System.Numerics;

namespace lab2_c
{
    class Fraction
    {
        private Bignum_arithmetic m;
        private Bignum_arithmetic n;
        public string fract_value;
        public Fraction(string value) {
            try {
                fract_value =  value;
                m = new Bignum_arithmetic(value.Split("/")[0]);
                n = new Bignum_arithmetic(value.Split("/")[1]);
            } 
            catch(InitException ie) {
                Console.WriteLine(ie.Message);
            }
        }

        public static implicit operator Fraction (Bignum_arithmetic ba) => (new Fraction($"{ba.bignum}/1"));
        public static implicit operator Fraction (int value) => (new Fraction($"{value}/1"));
        public static Fraction operator *(Fraction f1, Fraction f2) {
            BigInteger gcd = BigInteger.GreatestCommonDivisor(f1.m.bignum * f2.m.bignum, f1.n.bignum * f2.n.bignum);
            return new Fraction($"{f1.m.bignum * f2.m.bignum / gcd}/{f1.n.bignum * f2.n.bignum / gcd}");
        }

        public static Fraction operator /(Fraction f1, Fraction f2) {
            BigInteger gcd = BigInteger.GreatestCommonDivisor(f1.m.bignum * f2.n.bignum, f1.n.bignum * f2.m.bignum);
            return new Fraction($"{f1.m.bignum * f2.m.bignum / gcd}/{f1.n.bignum * f2.n.bignum / gcd}");
        }

        public static Fraction operator +(Fraction f1, Fraction f2) {
            BigInteger gcd = BigInteger.GreatestCommonDivisor(f1.m.bignum * f2.n.bignum + f2.m.bignum * f1.n.bignum, f1.n.bignum * f2.n.bignum);
            return new Fraction($"{f1.m.bignum * f2.n.bignum + f2.m.bignum * f1.n.bignum}/{f1.n.bignum * f2.n.bignum}");
        }

         public static Fraction operator -(Fraction f1, Fraction f2) {
            BigInteger gcd = BigInteger.GreatestCommonDivisor(f1.m.bignum * f2.n.bignum - f2.m.bignum * f1.n.bignum, f1.n.bignum * f2.n.bignum);
            return new Fraction($"{f1.m.bignum * f2.n.bignum - f2.m.bignum * f1.n.bignum}/{f1.n.bignum * f2.n.bignum}");
        }

    }
}
