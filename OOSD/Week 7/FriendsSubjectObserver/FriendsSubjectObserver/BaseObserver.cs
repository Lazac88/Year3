using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendsSubjectObserver
{
    public abstract class BaseObserver
    {
        protected MessagePostSubject mySubject;
        protected ListBox myListBox;
        protected string currentPost;

        public BaseObserver(MessagePostSubject mySubject, ListBox myListBox)
        {
            this.mySubject = mySubject;
            mySubject.AddObserver(this);
            this.myListBox = myListBox;
            currentPost = "";
        }

        public abstract void Update(string newPost);

        public virtual void Display()
        {
            DateTime timeStamp = DateTime.Now;
            string format = "ddd d MMM, yyyy h:mm";
            myListBox.Items.Add(timeStamp.ToString(format));
            myListBox.Items.Add(currentPost);
        }
    }
}
