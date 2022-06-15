

namespace InterfaceSegregationPrinciple
{
    /*The Interface Segregation Principle states that clients should not be forced to implement interfaces 
     * they don’t use. So instead of huge interfaces, it is better to create multiple small ones so that 
     * they are utilised in the best possible way.
     */
    public class OrderEntity : IOrder
    {
        public int OrderNumber { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryName { get; set; }

        public OrderEntity AddOrder()
        {
            System.Console.WriteLine("Add orders");
            return new OrderEntity();
        }

        public OrderEntity GetOrder()
        {
            System.Console.WriteLine("Get orders");
            return new OrderEntity();
        }

        public OrderEntity UpdateOrder()
        {
            System.Console.WriteLine("Update orders");
            return new OrderEntity();
        }
    }
}
