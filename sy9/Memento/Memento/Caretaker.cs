using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Caretaker
    {
        private GameMemento memento;

        // 保存备忘录
        public void SaveMemento(GameMemento memento)
        {
            this.memento = memento;
        }

        // 获取备忘录
        public GameMemento GetMemento()
        {
            return memento;
        }
    }
}
