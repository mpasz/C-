namespace Workflow
{
    public class PurchaseOrderStatus : IPurchaseStatus
    {
        
        public void Execute(Status status)
        {
            System.Console.WriteLine("Status of purchase request is : pending .... ");
        }
    }
}
