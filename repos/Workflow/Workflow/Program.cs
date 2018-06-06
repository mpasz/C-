using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var purchasePanel = new PurchasesPanel();
            purchasePanel.RegisterOrderStatus(new PurchaseOrderRequest()); 
            purchasePanel.RegisterOrderStatus(new PurchaseOrderStatus());
           // purchasePanel.RegisterOrderStatus(new PurchaseRequestStatus());
            

            purchasePanel.Panel(new Order());
        }
    }
}
