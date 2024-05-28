using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var product in products)
            {
                product.Accept(visitor);
            }
        }
    }
}
