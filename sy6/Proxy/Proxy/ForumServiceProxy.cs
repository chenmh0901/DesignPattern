using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ForumServiceProxy : IForumService
    {
        private ForumService realService;
        private bool isRegisteredUser;

        public ForumServiceProxy(bool isRegisteredUser)
        {
            this.realService = new ForumService();
            this.isRegisteredUser = isRegisteredUser;
        }

        public void ViewPosts()
        {
            realService.ViewPosts();
        }

        public void PostMessage(string message)
        {
            if (isRegisteredUser)
            {
                realService.PostMessage(message);
            }
            else
            {
                Console.WriteLine("只有注册用户才能发帖。");
            }
        }

        public void EditPost(int postId, string newMessage)
        {
            if (isRegisteredUser)
            {
                realService.EditPost(postId, newMessage);
            }
            else
            {
                Console.WriteLine("只有注册用户才能编辑帖子。");
            }
        }

        public void EditProfile(string newProfileInfo)
        {
            if (isRegisteredUser)
            {
                realService.EditProfile(newProfileInfo);
            }
            else
            {
                Console.WriteLine("只有注册用户才能编辑个人信息。");
            }
        }
    }
}
