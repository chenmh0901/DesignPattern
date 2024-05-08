using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IForumService
    {
        void ViewPosts();
        void PostMessage(string message);
        void EditPost(int postId, string newMessage);
        void EditProfile(string newProfileInfo);
    }
}
