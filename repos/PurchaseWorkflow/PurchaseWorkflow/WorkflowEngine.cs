namespace PurchaseWorkflow
{
    public class WorkflowEngine 
    {
        public void Run(Workflow workflow)
        {
            foreach (var status in workflow.workflowStatus)
                status.Execute();
        }
    }
}
