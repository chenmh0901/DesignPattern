using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Cashier:IVisitor
    {
         public void Visit(Apple apple)
    {
        Console.WriteLine($"收银员给苹果过称并计价: {apple.Name}");
        // 可以添加过称和计价的逻辑
    }

    public void Visit(Book book)
    {
        Console.WriteLine($"收银员为图书计价: {book.Name}");
        // 可以添加计价的逻辑
    }
    }
}
