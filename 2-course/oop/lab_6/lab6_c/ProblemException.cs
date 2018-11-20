using System;

namespace lab2_c
{
    class ProblemException: Exception
    {
        public ProblemException(string errMsg):base(errMsg) {}
    }
}
