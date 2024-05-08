using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsibility
{
    class LeaveRequest
    {
        public int Days { get; set; }
        public LeaveRequest(int days)
        {
            Days = days;
        }
    }
}
