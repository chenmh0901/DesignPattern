using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class AbstractPane
    {
        protected WindowMediator mediator;
        public AbstractPane(WindowMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
