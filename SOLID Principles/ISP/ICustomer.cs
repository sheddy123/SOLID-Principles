

namespace InterfaceSegregationPrinciple
{
    public interface ICustomer
    {
        public CustomerEntity GetCustomer();
        public CustomerEntity AddCustomer();
        public CustomerEntity UpdateCustomerName();
    }
}
