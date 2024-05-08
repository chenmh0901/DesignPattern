using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class CommandManager
    {
        private List<ICommand> commands = new List<ICommand>();
        private int current = 0; // 当前命令位置

        public void Invoke(ICommand command)
        {
            command.Execute();
            // 如果在中间Undo之后执行了新命令未执行Redo, 则删除该位置之后的所有命令
            commands = commands.Take(current + 1).ToList();
            commands.Add(command);
            current++;

        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    ICommand command = commands[--current];
                    command.UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    ICommand command = commands[current++];
                    command.Execute();
                }
            }
        }
    }
}
