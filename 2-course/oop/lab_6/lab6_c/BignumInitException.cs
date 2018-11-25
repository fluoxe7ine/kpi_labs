using System;

namespace lab2_c
{
    class BignumInitException : InitException
    {
        public BignumInitException(string errMsg):base(errMsg) {}
    }
}
