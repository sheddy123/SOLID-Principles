

namespace InterfaceSegregationPrinciple
{
    public interface IOrder
    {
        public OrderEntity GetOrder();
        public OrderEntity AddOrder();
        public OrderEntity UpdateOrder();
    }
}
