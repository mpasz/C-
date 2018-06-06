using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var purchasePanel = new PurchasesPanel();
            var orderWorkflow = new OrderWorkflow();
            //purchasePanel.Run(new PurchaseOrderRequest()); 
            //purchasePanel.Run(new PurchaseOrderStatus());
            //purchasePanel.RegisterOrderStatus(new PurchaseRequestStatus());


            purchasePanel.Run(orderWorkflow);
        }
    }
}
