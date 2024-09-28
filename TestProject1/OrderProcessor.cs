namespace TestProject1;

public partial class ClassRelationshipsTest
{
    class OrderProcessor
    {
        private readonly EmailSender _emailSender;

        public OrderProcessor(EmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public Order ProcessOrder(Order order)
        {
            return order;
        }
    }



}