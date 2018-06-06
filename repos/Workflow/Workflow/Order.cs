using System.Collections.Generic;

namespace Workflow
{
    public class Order
    {
           public IList<IPurchaseStatus> OrdersStatus { get; set; } = new List<IPurchaseStatus>();    
    }
}
