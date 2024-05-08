using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class ValueNode:AbstractNode
    {
        private int value;

        public ValueNode(int value)
        {
            this.value = value;
        }

        public override int Interpret()
        {
            return this.value;
        }
    }
}
