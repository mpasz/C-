namespace PurchaseWorkflow
{
    public class EmailFromPurchaseDepartment : IWorkflowStatus
    {
        public void Execute()
        {
            System.Console.WriteLine("Sending an email with information about status of the purchase order");
        }
    }
}
