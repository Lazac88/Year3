using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimalNoises
{
    class Animal
    {
        private SoundPlayer soundPlayer;

        public Animal()
        {
            soundPlayer = new SoundPlayer("frog.wav");
        }

        public void speak()
        {
            while (true)
            {
                soundPlayer.Play();
                Thread.Sleep(1000);
            }
        }
    }
}
