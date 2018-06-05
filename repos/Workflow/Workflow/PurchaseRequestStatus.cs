namespace Workflow
{
    public class PurchaseRequestStatus : IPurchaseStatus
    {
        public void Execute(Status status)
        {
            System.Console.WriteLine("Purchase order based on request added to the system ");
        }
    }
}
