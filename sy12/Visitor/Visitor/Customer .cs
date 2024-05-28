using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Customer:IVisitor
    {
        public void Visit(Apple apple)
        {
            Console.WriteLine($"顾客正在检查苹果: {apple.Name}");
            // 可以添加检查苹果质量的逻辑
        }

        public void Visit(Book book)
        {
            Console.WriteLine($"顾客正在检查图书: {book.Name}");
            // 可以添加检查图书内容的逻辑
        }
    }
}
