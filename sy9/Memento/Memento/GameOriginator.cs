using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class GameOriginator
    {
        private string state;

        // 设置游戏状态
        public void SetState(string state)
        {
            this.state = state;
            Console.WriteLine("Current State: " + state);
        }

        // 保存状态到备忘录
        public GameMemento SaveStateToMemento()
        {
            return new GameMemento(state);
        }

        // 恢复状态从备忘录
        public void GetStateFromMemento(GameMemento memento)
        {
            state = memento.State;
            Console.WriteLine("State restored to: " + state);
        }
    }
}
