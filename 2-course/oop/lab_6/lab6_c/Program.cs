using System;
using System.Numerics;

namespace lab2_c
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Matrix matrix1 = new Matrix(3, 5);
                Bignum_arithmetic ba1 = new Bignum_arithmetic("10");
                Matrix matrix2 = new Matrix(3, 5);
                Fraction fa1 = new Fraction("-213/1");
                matrix1.fillMatrix();
                matrix2.fillMatrix();
                Matrix matrix3 = 5 + matrix1 + matrix2 / ba1 * fa1 * 1000;
                Matrix show = ~matrix3;
            }
            catch (InitException ie) {
                Console.WriteLine(ie.Message);
            }
            catch (ProblemException pe) {
                Console.WriteLine(pe.Message);
            }
            catch (Exception e) {
                Console.WriteLine("System exception: " + e.Message);
            }
        }
    }
}
