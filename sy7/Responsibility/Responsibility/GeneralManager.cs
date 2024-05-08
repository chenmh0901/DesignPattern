using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsibility
{
    class GeneralManager:Approver
    {
        public override void ProcessRequest(LeaveRequest request)
        {
            if (request.Days >= 10 && request.Days < 30)
            {
                Console.WriteLine($"{this.GetType().Name} approved request for {request.Days} days.");
            }
            else if (request.Days >= 30)
            {
                Console.WriteLine("Request denied. Please, consult HR for leave more than 30 days.");
            }
        }
    }
}
