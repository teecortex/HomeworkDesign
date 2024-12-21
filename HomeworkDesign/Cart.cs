using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDesign
{
    public class Cart
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DisplayCart()
        {
            foreach (var product in Products)
            {
                product.DisplayDetails();
            }
        }
    }

}
