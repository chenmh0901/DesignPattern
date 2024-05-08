using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new PaneMediator();

            // 创建窗格实例时传递中介者实例
            mediator.textPane = new TextPane(mediator);
            mediator.listPane = new ListPane(mediator);
            mediator.graphicPane = new GraphicPane(mediator);

            // 触发改变
            mediator.textPane.Changed();
        }
    }
}
