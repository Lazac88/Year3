using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomEventHandlers
{
    public class ButtonObserver
    {
        private int secretNum;

        private Button subject;

        public ButtonObserver(Button subject, int secretNum)
        {
            this.subject = subject;

            //EventHandler is a System defined event handler that does what we need
            //Therefore do not need to define a custom one
            EventHandler handler = new EventHandler(ButtonPressHandlerMethod);


            //Click is the event defined by the button
            subject.Click += handler;

            this.secretNum = secretNum;
        }


        public void ButtonPressHandlerMethod(object btnSubject, EventArgs e)
        {
            string myMessage = "This is a custom handler.\n";
            myMessage += "My code number is " + secretNum + ".\n";
            myMessage += "My type is " + this.GetType() + ".\n";
            myMessage += "I am responding to button: " + subject.Name + ".";

            MessageBox.Show(myMessage);
        }
    }
}
