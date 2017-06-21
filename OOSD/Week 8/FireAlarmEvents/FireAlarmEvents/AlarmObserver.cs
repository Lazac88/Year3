using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace FireAlarmEvents
{
    public class AlarmObserver : FireAlarmObserverBase
    {
        SoundPlayer player;
 
 
        public AlarmObserver(FireAlarmSubject subject)
            : base(subject)
        {
            this.subject = subject;

            //Below must be fully qualified
            //Grab the created event handler in the subject class and add the method to be run
            FireAlarmSubject.FireEventHandler handler = new FireAlarmSubject.FireEventHandler(FireAlarmHandlerMethod);

            //Add the handler to our instance of the subject class
            subject.FireEvent += handler;

            player = new System.Media.SoundPlayer();
        }

        public override void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe)
        {
            switch (fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    //make sound
                    player.SoundLocation = "ahem.wav";
                    break;
                case EFireCategory.SERIOUS:
                    //make sound
                    player.SoundLocation = "beep.wav";
                    break;
                case EFireCategory.INFERNO:
                    //make sound
                    player.SoundLocation = "air_raid.wav";
                    break;
            }

            player.Load();
            player.Play();
        }
    }
}
