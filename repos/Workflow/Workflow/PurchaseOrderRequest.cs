namespace Workflow
{
    public class PurchaseOrderRequest : IPurchaseStatus
    {
        public void Execute(Status status)
        {
            System.Console.WriteLine("Purchase requeest added!");
        }
    }
}
