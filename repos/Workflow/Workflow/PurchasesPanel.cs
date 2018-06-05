using System;
using System.Collections.Generic;

namespace Workflow
{
    public class PurchasesPanel
    {

        private readonly IList<IPurchaseStatus> _purchaseStatus;

        public PurchasesPanel()
        {
            _purchaseStatus = new List<IPurchaseStatus>();
        }

        public void Panel(Order order)
        {
            foreach (var request in _purchaseStatus)
                request.Execute(new Status());
        }
        
        public void RegisterOrderStatus(IPurchaseStatus step)
        {
            _purchaseStatus.Add(step);
        }
    }
}
