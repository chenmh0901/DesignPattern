using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            CommandManager commandManager = new CommandManager();

            // 执行一些命令
            commandManager.Invoke(new CalculatorCommand(calculator, '+', 100));
            commandManager.Invoke(new CalculatorCommand(calculator, '-', 50));
            commandManager.Invoke(new CalculatorCommand(calculator, '*', 10));

            // 撤销两步
            commandManager.Undo(2);

            // 重做一步
            commandManager.Redo(1);

            // 执行新的命令
            commandManager.Invoke(new CalculatorCommand(calculator, '/', 2));

            // 重做一步 (此时不会有任何动作，因为没有命令可以重做)
            commandManager.Redo(1);
        }
    }
}
