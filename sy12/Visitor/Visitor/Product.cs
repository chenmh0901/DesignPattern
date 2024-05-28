using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Product
    {
        public string Name { get; set; }
        public abstract void Accept(IVisitor visitor);
    }
}
