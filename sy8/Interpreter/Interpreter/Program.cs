using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "3*4/2%4";
            Console.WriteLine("表达式：{0}",expression);
            OperationHandler handler = new OperationHandler();
            handler.Handle(expression);

            Console.WriteLine("结果：{0}", handler.OutPut());
        }
    }
}
