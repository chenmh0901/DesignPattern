using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ForumService : IForumService
    {
        public void ViewPosts()
        {
            Console.WriteLine("显示帖子内容。");
        }

        public void PostMessage(string message)
        {
            Console.WriteLine($"发帖内容：{message}");
        }

        public void EditPost(int postId, string newMessage)
        {
            Console.WriteLine($"编辑帖子：{postId}，新内容：{newMessage}");
        }

        public void EditProfile(string newProfileInfo)
        {
            Console.WriteLine($"更新个人信息：{newProfileInfo}");
        }
    }
}
