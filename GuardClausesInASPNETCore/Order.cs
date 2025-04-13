using Ardalis.GuardClauses;

namespace GuardClausesInASPNETCore
{
    public class Order
    {
        public string CustomerEmail { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public Order(string customerEmail, string? orderNumber, DateTime? orderData)
        {
            //CustomerEmail = Guard.Against.InvalidEmailAddress(customerEmail, nameof(customerEmail));
            CustomerEmail = Guard.Against.InvalidEmailAddressWithCustomEmailSuffix(customerEmail,".dev" ,nameof(customerEmail));
            OrderNumber = orderNumber;
            OrderDate = orderData;
        }
    }
}
