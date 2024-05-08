using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class TextPane : AbstractPane
    {
        public TextPane(WindowMediator mediator) : base(mediator) { }

        public void Changed()
        {
            mediator.PaneChanged(this);
        }

        public void Update()
        {
        }
    }
}
