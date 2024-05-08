using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class DivideNode: AbstractNode
    {
        private AbstractNode left;
        private AbstractNode right;

        public DivideNode(AbstractNode left, AbstractNode right)
        {
            this.left = left;
            this.right = right;
        }

        public override int Interpret()
        {
            return left.Interpret()/right.Interpret();
        }
    }
}
