using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CalculatorCommand:ICommand
    {
        private Calculator calculator;
        private char @operator;
        private int operand;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.calculator = calculator;
            this.@operator = @operator;
            this.operand = operand;
        }

        // 执行新的命令
        public void Execute()
        {
            calculator.Operation(@operator, operand);
        }

        // 撤销上一步命令
        public void UnExecute()
        {
            calculator.Operation(Undo(@operator), operand);
        }

        // 获取相反操作
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Unknown operator");
            }
        }
    }
}
