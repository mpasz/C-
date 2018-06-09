using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            var workflow = new Workflow();
            workflowEngine.Run(workflow);
        }
    }
}
