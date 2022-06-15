

namespace InterfaceSegregationPrinciple
{
    /*The Interface Segregation Principle states that clients should not be forced to implement interfaces 
     * they don’t use. So instead of huge interfaces, it is better to create multiple small ones so that 
     * they are utilised in the best possible way.
     */
    public class CustomerEntity : ICustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public CustomerEntity AddCustomer()
        {
            System.Console.WriteLine("Customer added");
            return new CustomerEntity();
        }

        public CustomerEntity GetCustomer()
        {
            System.Console.WriteLine("Get all customers");
            return new CustomerEntity();
        }

        public CustomerEntity UpdateCustomerName()
        {
            System.Console.WriteLine("Customers updated");
            return new CustomerEntity();
        }
    }
}
