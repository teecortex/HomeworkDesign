using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public interface IOrderState
    {
        void HandleOrder(Order order);
    }
}
