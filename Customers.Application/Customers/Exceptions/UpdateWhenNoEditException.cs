﻿namespace Customers.Application.Customers.Exceptions
{
    public class UpdateWhenNoEditException : Exception
    {
        public override string Message { get; }

        public UpdateWhenNoEditException() : base() 
        {
            Message = "Could not edit";
        }

    }

}
