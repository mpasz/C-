namespace PurchaseWorkflow
{
    public class EmailToPurchaseDepartment : IWorkflowStatus
    {
        public void Execute()
        {
            System.Console.WriteLine("Sending an email with purchase request informaation");
        }
    }
}
