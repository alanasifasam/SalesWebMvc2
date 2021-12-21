using System;

namespace SalesWebMvc2.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException (string message) : base(message)
        {

        }
    }
}
