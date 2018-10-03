using System;

namespace lab2_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(3, 5);
            Matrix matrix2 = new Matrix(3, 5);
            Bignum_arithmetic ba1 = new Bignum_arithmetic("10");
            Fraction fa1 = new Fraction("-2/1");
            matrix1.fillMatrix();
            matrix2.fillMatrix();
            Matrix matrix3 = 5 + matrix1 + matrix2 - ba1 * fa1 * 1000;
            matrix1.showMatrix();
            Console.WriteLine();
            matrix3.showMatrix();
            Matrix matrix4 = -matrix3;
            Console.WriteLine();
            matrix4.showMatrix();
            Matrix matrix5 = !matrix3;
            Console.WriteLine();
            matrix5.showMatrix();
        }
    }
}
