namespace PurchaseWorkflow
{
    public class PurchaseRequestAcceptation : IWorkflowStatus
    {
        public void Execute()
        {
            System.Console.WriteLine("The request acceptation. Upgrade to purchase order");
        }
    }
}
