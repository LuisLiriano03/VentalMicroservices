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
