using System;

namespace lab2_c
{
    class MatrixInitException : InitException
    {
        public MatrixInitException(string errMsg):base(errMsg) {}
    }
}
