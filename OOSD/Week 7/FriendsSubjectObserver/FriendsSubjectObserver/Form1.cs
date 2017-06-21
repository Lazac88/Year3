using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendsSubjectObserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MessagePostSubject mySubject;
        FriendObserver friend1;
        FriendObserver friend2;
        FriendObserver friend3;
        FriendObserver friend4;
        SelfObserver selfObserver;

        private void Form1_Load(object sender, EventArgs e)
        {
            mySubject = new MessagePostSubject();
            selfObserver = new SelfObserver(mySubject, listBoxMain);
            friend1 = new FriendObserver(mySubject, listBoxFriend1);
            friend2 = new FriendObserver(mySubject, listBoxFriend2);
            friend3 = new FriendObserver(mySubject, listBoxFriend3);
            friend4 = new FriendObserver(mySubject, listBoxFriend4);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string newPost = txtBoxInput.Text;
            mySubject.AlertObservers(newPost);
        }
    }
}
