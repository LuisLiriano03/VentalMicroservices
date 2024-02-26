using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Application.Customers.Exceptions
{
    public class FailedCreateException : Exception
    {
        public override string Message { get; }

        public FailedCreateException() : base()
        {
            Message = "Failed to create";
        }

    }

}
