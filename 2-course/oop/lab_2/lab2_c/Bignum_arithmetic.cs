using System;
using System.Collections.Generic;
using System.Numerics;
namespace lab2_c
{
    class Bignum_arithmetic
    {
        public BigInteger bignum;
        public Bignum_arithmetic(string number) {
            bignum = BigInteger.Parse(number);
        }

        public Bignum_arithmetic(BigInteger number) {
            bignum = number;
        }

        public static Bignum_arithmetic operator +(Bignum_arithmetic left, Bignum_arithmetic right) {
            return new Bignum_arithmetic(BigInteger.Add(left.bignum, right.bignum));
        }

        public static Bignum_arithmetic operator -(Bignum_arithmetic left, Bignum_arithmetic right) {
            return new Bignum_arithmetic(BigInteger.Subtract(left.bignum, right.bignum));
        }

        public static Bignum_arithmetic operator *(Bignum_arithmetic left, Bignum_arithmetic right) {
            return new Bignum_arithmetic(BigInteger.Multiply(left.bignum, right.bignum));
        }

        public static Bignum_arithmetic operator /(Bignum_arithmetic left, Bignum_arithmetic right) {
            return new Bignum_arithmetic(BigInteger.Divide(left.bignum, right.bignum));
        }

       

    }
}
