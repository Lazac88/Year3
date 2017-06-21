using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendsSubjectObserver
{
    public class FriendObserver : BaseObserver
    {
        public FriendObserver(MessagePostSubject mySubject, ListBox myListBox)
            : base(mySubject, myListBox)
        {

        }
        public override void Update(string newPost)
        {
            currentPost = newPost;
            Display();
        }
    }
}
