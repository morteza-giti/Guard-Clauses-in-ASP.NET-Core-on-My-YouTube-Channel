using Ardalis.GuardClauses;

namespace GuardClausesInASPNETCore
{
    public interface IPaymentGateway
    {

    }
    public interface IOrderRepository
    {

    }
    public class OrderProcessingService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IPaymentGateway paymentGateway;

        public OrderProcessingService(IOrderRepository orderRepository, IPaymentGateway paymentGateway)
        {
            //if (orderRepository == null)
            //{
            //    throw new ArgumentException("Order Repository cannot be null");
            //}
            //if (paymentGateway == null)
            //{
            //    throw new ArgumentException("Payment Gateway cannot be null");
            //}

            this.orderRepository = Guard.Against.Null(orderRepository, nameof(orderRepository));
            this.paymentGateway = Guard.Against.Null(paymentGateway, nameof(paymentGateway));
        }
    }
}
