using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendsSubjectObserver
{
    public class SelfObserver : BaseObserver
    {
        public SelfObserver(MessagePostSubject mySubject, ListBox myListBox)
            : base (mySubject, myListBox)
        {
            
        }
        public override void Update(string newPost)
        {
            currentPost = newPost;
            Display();
        }

        public override void Display()
        {
            myListBox.Items.Clear();
            myListBox.Items.Add(currentPost);
        }
    }
}
