using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public class DressFactory : ProductFactory
    {
        public override Product CreateProduct(string name, decimal price)
        {
            return new Dress(name, price);
        }
    }
}
