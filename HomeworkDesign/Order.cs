using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public class Order
    {
        private IOrderState _state;

        public Order()
        {
            _state = new InactiveOrderState();
        }

        public void SetState(IOrderState state)
        {
            _state = state;
        }

        public void Handle()
        {
            _state.HandleOrder(this);
        }
    }
}
