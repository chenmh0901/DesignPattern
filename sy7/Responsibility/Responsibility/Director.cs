using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsibility
{
    class Director : Approver
    {
        public override void ProcessRequest(LeaveRequest request)
        {
            if (request.Days < 3)
            {
                Console.WriteLine($"{this.GetType().Name} approved request for {request.Days} days.");
            }
            else if (successor != null)
            {
                successor.ProcessRequest(request);
            }
        }
    }
}
