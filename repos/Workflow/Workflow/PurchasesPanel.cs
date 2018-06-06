using System;
using System.Collections.Generic;

namespace Workflow
{
    public class PurchasesPanel
    {

        public void Run(Order order)
        {
            foreach (var request in order.OrdersStatus)
                request.Execute();
        }
        
    }
}
