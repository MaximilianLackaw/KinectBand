using Kinect.KinectBand.Instruments;
using Microsoft.Kinect.VisualGestureBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinect.KinectBand
{
    public interface IInstrumentGesture
    {
        void UpdateGestureResult();
    }

    public class InstrumentGesture : IInstrumentGesture
    {
        private readonly DiscreteGestureResult discreteGestureResult;
        private readonly IInstrument instrument;

        public InstrumentGesture(DiscreteGestureResult discreteGestureResult, IInstrument instrument)
        {
            this.discreteGestureResult = discreteGestureResult;
            this.instrument = instrument;
        }

        public void UpdateGestureResult()
        {
            if (discreteGestureResult.Detected)
            {
                instrument.Play();
            }
            else
            {
                instrument.Stop();
            }
        }
    }
}
