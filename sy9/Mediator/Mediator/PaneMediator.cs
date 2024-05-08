using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class PaneMediator:WindowMediator
    {
        public TextPane textPane;
        public ListPane listPane;
        public GraphicPane graphicPane;

        public PaneMediator()
        {
        }

        // 在构造函数中初始化窗口和每个窗格
        public PaneMediator(TextPane textPane, ListPane listPane, GraphicPane graphicPane)
        {
            this.textPane = textPane;
            this.listPane = listPane;
            this.graphicPane = graphicPane;
        }

        public override void PaneChanged(AbstractPane pane)
        {
            if (pane is TextPane)
            {
                // 在TextPane改变时更新ListPane和GraphicPane
                listPane.Update();
                graphicPane.Update();
            }

            // 根据需要添加更多的分支，处理ListPane和GraphicPane改变时的情况
        }
    }
}
