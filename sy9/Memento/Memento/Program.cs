using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            GameOriginator originator = new GameOriginator();
            Caretaker caretaker = new Caretaker();

            originator.SetState("Level 1");
            caretaker.SaveMemento(originator.SaveStateToMemento());

            originator.SetState("Level 2");
            Console.WriteLine("玩家死亡");
            originator.GetStateFromMemento(caretaker.GetMemento()); // 如果玩家失败，可以恢复到先前的状态

            Console.ReadLine();
        }
    }
}
