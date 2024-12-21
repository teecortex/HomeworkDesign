using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public class InactiveOrderState : IOrderState
    {
        public void HandleOrder(Order order)
        {
            Console.WriteLine("Order is now active.");
            order.SetState(new ActiveOrderState());
        }
    }
}
