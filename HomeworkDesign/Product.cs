using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract void DisplayDetails();
    }
}
