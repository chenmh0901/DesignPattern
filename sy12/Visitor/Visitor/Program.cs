using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddProduct(new Apple("红富士苹果"));
            cart.AddProduct(new Book("《C#编程指南》"));

            Customer customer = new Customer();
            Cashier cashier = new Cashier();

            Console.WriteLine("顾客访问购物车中的商品...");
            cart.Accept(customer);

            Console.WriteLine("\n收银员访问购物车中的商品...");
            cart.Accept(cashier);
        }
    }
}
