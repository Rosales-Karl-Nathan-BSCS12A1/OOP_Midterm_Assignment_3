namespace TestProject1;

public partial class ClassRelationshipsTest
{
    class Customer
    {
        private List<Order> orders;

        public Customer()
        {
            orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetOrders()
        {
            return orders;
        }
    }
}