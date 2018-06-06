namespace Workflow
{
    partial class Program
    {
        public class OrderWorkflow : Order
        {
            public OrderWorkflow() : base()
            {
                OrdersStatus.Add(new PurchaseOrderRequest());
                OrdersStatus.Add(new PurchaseOrderStatus());
                OrdersStatus.Add(new PurchaseRequestStatus());
            }
        }
    }
}
