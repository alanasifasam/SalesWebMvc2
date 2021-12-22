using System;


namespace SalesWebMvc2.Services.Exceptions
{
    public class IntegrityException :ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {

        }
    }
}
