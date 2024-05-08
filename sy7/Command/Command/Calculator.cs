using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Calculator
    {
        private int currentValue;

        public int Value => currentValue;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': currentValue += operand; break;
                case '-': currentValue -= operand; break;
                case '*': currentValue *= operand; break;
                case '/': currentValue /= operand; break;
            }
            Console.WriteLine($"Current value = {currentValue} (following {@operator} {operand})");
        }
    }
}
