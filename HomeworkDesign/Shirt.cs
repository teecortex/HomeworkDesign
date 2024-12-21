using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public class Shirt : Product
    {
        public Shirt(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Shirt: {Name}, Price: {Price}");
        }
    }
}
