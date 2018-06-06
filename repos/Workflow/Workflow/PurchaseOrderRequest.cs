namespace Workflow
{
    public class PurchaseOrderRequest : IPurchaseStatus
    {
        public void Execute()
        {
            System.Console.WriteLine("Purchase requeest added!");
        }
    }
}
