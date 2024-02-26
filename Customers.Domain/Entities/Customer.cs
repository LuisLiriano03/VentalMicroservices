using Customers.Domain.Models;

namespace Customers.Domain.Entities
{
    public class Customer : Entity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTimeOffset RegistrationDate { get; set; } 
        public DateTimeOffset LastPurchaseDate { get; set; } 

    }

}
