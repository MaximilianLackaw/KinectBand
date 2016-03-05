using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.Kinect.DiscreteGestureBasics
{
    public interface IInstrument
    {
        void Play();

        void Stop();
    }

    public class DrumInstrument : IInstrument
    {
        System.Media.SoundPlayer player;

        private bool isPlaying;

        public DrumInstrument()
        {
            player = new System.Media.SoundPlayer(@"Samples\A_Triplet_Riff_2a.wav");
            player.Load();
            this.isPlaying = false;
        }


        public void Play()
        {
            if (!this.isPlaying)
            {
                player.PlayLooping();
            }

            this.isPlaying = true;
        }

        public void Stop()
        {
            player.Stop();
            this.isPlaying = false;
        }
    }
}
