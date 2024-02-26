namespace Customers.Application.Customers.Exceptions
{
    public class WhenNoDeleteException : Exception
    {
        public override string Message { get; }

        public WhenNoDeleteException() : base()
        {
            Message = "Could not delete";
        }

    }

}
