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
            CustomerEmail = Guard.Against.NullOrEmpty(customerEmail, nameof(customerEmail), "Customer email address cannot be null or empty.");
            OrderNumber = orderNumber;
            OrderDate = orderData;
        }
    }
}
