using System;

namespace PurchaseWorkflow
{
    public class PurchaseRequestRegistration : IWorkflowStatus
    {
        public void Execute()
        {
            Console.WriteLine("Your request was registered. Wait for reply from Purchase Department");
        }
    }
}
