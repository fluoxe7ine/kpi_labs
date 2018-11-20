using System;

namespace lab2_c
{
    class InitException : Exception
    {
        public InitException(string errMsg):base(errMsg) {}
    }
}
