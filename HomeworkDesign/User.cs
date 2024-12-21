using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public class User : IObserver
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Update(Order order)
        {
            Console.WriteLine($"User {Name} has been notified: Order status changed.");
        }
    }
}
