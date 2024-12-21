using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public abstract class ProductFactory
    {
        public abstract Product CreateProduct(string name, decimal price);
    }
}
