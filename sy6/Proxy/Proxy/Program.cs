using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ForumServiceProxy registeredUserProxy = new ForumServiceProxy(true);
            registeredUserProxy.PostMessage("这是我的新帖子！");
            registeredUserProxy.EditProfile("更新个人信息");

            ForumServiceProxy guestUserProxy = new ForumServiceProxy(false);
            guestUserProxy.ViewPosts(); // 游客可以浏览帖子
            guestUserProxy.PostMessage("我想发个帖子试试。"); // 提示权限不足
        }
    }
}
