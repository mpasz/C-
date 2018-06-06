namespace Workflow
{
    public class PurchaseOrderStatus : IPurchaseStatus
    {
        
        public void Execute()
        {
            System.Console.WriteLine("Status of purchase request is : pending .... ");
        }
    }
}
