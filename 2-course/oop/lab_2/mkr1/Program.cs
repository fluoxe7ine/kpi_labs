using System;

namespace lab2_c
{
    class Program
    {
        static void Main(string[] args)
        {
            M matrix1 = new Matrix(2,3);
            matrix1.fillMatrix();
            matrix1.showMatrix();
            matrix1.Kramer();
            matrix1.Substitute();
        }
    }
}
