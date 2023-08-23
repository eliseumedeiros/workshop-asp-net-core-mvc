using System;

namespace SalesWebMvcApp.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
