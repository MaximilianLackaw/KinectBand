using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.Kinect.DiscreteGestureBasics.Instruments
{
    public interface IInstrument
    {
        void Play();

        void Stop();
    }

    public abstract class BaseInstrument : IInstrument
    {
        private bool isPlaying;
        private string name;
        private SoundPlayer player;

        public BaseInstrument(String name)
        {
            this.player = new System.Media.SoundPlayer(string.Format("Samples\\{0}.wav", name));
            this.name = name;
            player.Load();
            this.isPlaying = false;
        }

        public string GetInstrumentName()
        {
            return this.name;
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
