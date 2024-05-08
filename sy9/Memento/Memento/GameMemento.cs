using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class GameMemento
    {
        public string State { get; private set; }

        public GameMemento(string state)
        {
            this.State = state; // 保存游戏场景的某种状态（可以是玩家位置、生命值等）
        }
    }
}
