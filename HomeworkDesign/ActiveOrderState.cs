using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public class ActiveOrderState : IOrderState
    {
        public void HandleOrder(Order order)
        {
            Console.WriteLine("Order is ready for delivery.");
            order.SetState(new DeliveredOrderState());
        }
    }
}
