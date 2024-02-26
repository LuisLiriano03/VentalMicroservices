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
