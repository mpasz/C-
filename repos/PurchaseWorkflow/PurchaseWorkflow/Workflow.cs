using System.Collections.Generic;

namespace PurchaseWorkflow
{

    public class Workflow
    {
        public IList<IWorkflowStatus> workflowStatus = new List<IWorkflowStatus>();

        public Workflow()
        {
            workflowStatus.Add(new PurchaseRequestRegistration());
            workflowStatus.Add(new EmailToPurchaseDepartment());
            workflowStatus.Add(new PurchaseRequestAcceptation());
            workflowStatus.Add(new EmailFromPurchaseDepartment());
        }

        
    }
}
