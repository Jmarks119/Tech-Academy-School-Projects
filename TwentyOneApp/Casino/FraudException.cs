using System;

namespace Casino
{
    public class FraudException : ApplicationException
    {
        public FraudException()
            :base() { }
        public FraudException(string message)
            :base(message) { }
    }
}
