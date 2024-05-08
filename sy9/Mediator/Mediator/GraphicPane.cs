using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class GraphicPane:AbstractPane
    {
        public GraphicPane(WindowMediator mediator) : base(mediator) { }

        public void Update()
        {
            Console.WriteLine("GraphicPane更新");
        }
    }
}
