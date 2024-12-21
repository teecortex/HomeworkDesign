using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public class Dress : Product
    {
        public Dress(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Dress: {Name}, Price: {Price}");
        }
    }
}
