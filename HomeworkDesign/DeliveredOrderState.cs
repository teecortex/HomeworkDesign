using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public class DeliveredOrderState : IOrderState
    {
        public void HandleOrder(Order order)
        {
            Console.WriteLine("Order has been delivered.");
        }
    }
}
