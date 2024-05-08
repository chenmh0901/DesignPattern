using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver director = new Director();
            Approver manager = new Manager();
            Approver generalManager = new GeneralManager();

            // 设置职责链
            director.SetSuccessor(manager);
            manager.SetSuccessor(generalManager);

            // 发起请假请求
            director.ProcessRequest(new LeaveRequest(2)); // 主任审批
            director.ProcessRequest(new LeaveRequest(5)); // 经理审批
            director.ProcessRequest(new LeaveRequest(15)); // 总经理审批
            director.ProcessRequest(new LeaveRequest(30)); // 被拒绝
        }
    }
}
