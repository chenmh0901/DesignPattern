using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ListPane : AbstractPane
    {
        public ListPane(WindowMediator mediator) : base(mediator) { }

        public void Update()
        {
            Console.WriteLine("ListPane更新");
        }
    }
}
