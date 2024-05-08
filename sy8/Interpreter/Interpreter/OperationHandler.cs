using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class OperationHandler
    {
        private AbstractNode node;

        public void Handle(string expression)
        {
            AbstractNode left = null, right = null;
            Stack<AbstractNode> stack = new Stack<AbstractNode>();
            for (int i=0;i<expression.Length; i++)
            {
                if (expression[i] == '*')
                {
                    left = stack.Pop();
                    right =new ValueNode(expression[++i] - '0');
                    stack.Push(new MultiplyNode(left,right));
                }
                else if (expression[i] == '/')
                {
                    left = stack.Pop();
                    right = new ValueNode(expression[++i] - '0');
                    stack.Push(new DivideNode(left, right));
                }
                else if (expression[i] == '%')
                {
                    left = stack.Pop();
                    right = new ValueNode(expression[++i] - '0');
                    stack.Push(new ModuloNode(left, right));
                }
                else
                {
                    stack.Push(new ValueNode(expression[i] - '0'));
                }
            }
            this.node=stack.Pop();
        }

        public int OutPut()
        {
            return node.Interpret();
        }

        private void Print(char s,Stack<AbstractNode> stack)
        {
            if(stack.Count > 0)
            {
                Console.WriteLine("遇到：" + s);
                Console.WriteLine("运算结果："+stack.Peek().Interpret());
            }
        }
    }
}
