namespace Workflow
{
    public class PurchaseRequestStatus : IPurchaseStatus
    {
        public void Execute()
        {
            System.Console.WriteLine("Purchase order based on request added to the system ");
        }
    }
}
