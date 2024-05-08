using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class ModuloNode:AbstractNode
    {
        private AbstractNode left;
        private AbstractNode right;

        public ModuloNode(AbstractNode left, AbstractNode right)
        {
            this.left = left;
            this.right = right;
        }

        public override int Interpret()
        {
            return left.Interpret()%right.Interpret();
        }
    }
}
