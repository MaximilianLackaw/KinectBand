using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Kinect.KinectBand.Instruments
{
    public interface IInstrument
    {
        void Play(ulong trackingId);

        void Stop(ulong trackingId);
    }

    public abstract class BaseInstrument : IInstrument
    {
        private ulong id;
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

        public void Play(ulong trackingId)
        {
            if (!this.isPlaying)
            {
                //this.id = trackingId;
                ////System.Console.WriteLine("PLAY " + this.name);
                player.PlayLooping();
            }

            this.isPlaying = true;
        }

        public void Stop(ulong trackingId)
        {
            
            if (this.isPlaying) {
            //if (this.isPlaying && trackingId == id)
                player.Stop();
                this.isPlaying = false;
            }
            
            
        }
    }
}
