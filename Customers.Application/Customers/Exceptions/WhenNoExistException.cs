using Customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Application.Customers.Exceptions
{
    public class WhenNoExistException : Exception
    {
        public override string Message { get; }

        public WhenNoExistException() : base()
        {
            Message = "The costumer does not exist";
        }

    }

}
