using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    enum MachineParts
    {
        FirstTrackStart,
        CorruptionCheck,
        CorruptedBasket,
        FirstTrackEnd,
        SizeCheck,
        BigSizeTrack,
        SmallSizeTrack,
        BigBasket,
        SmallBasket

    }


    abstract class VMachinePart
    {
        public Apple apple = null;


        abstract public void updateSensors(); // Activate Ins 
        abstract public MachineParts? takeAction(); // Check Outs then move apples accordingly

    }

    class FirstTrackStart : VMachinePart
    {
        public override MachineParts? takeAction()
        {

            if (Lpt.getOutputs(0))
                return MachineParts.CorruptionCheck;

            return null;

        }

        public override void updateSensors()
        {
            //Activate Sensor if apple exist
            Lpt.setInputs(3, apple != null);
        }
    }

    class CorruptionCheck : VMachinePart
    {
        public override void updateSensors()
        {
            Lpt.setInputs(3, apple != null && apple.isCorrupted);

        }

        public override MachineParts? takeAction()
        {

            if (Lpt.getOutputs(1))
                return MachineParts.CorruptedBasket;

            return MachineParts.FirstTrackEnd;
        }
    }

    class FirstTrackEnd : VMachinePart
    {
        public override void updateSensors()
        {
        }

        public override MachineParts? takeAction()
        {

            return MachineParts.SizeCheck;
        }
    }

    class CorruptedBasket : VMachinePart
    {
        public override void updateSensors()
        {

        }

        public override MachineParts? takeAction()
        {
            return null;
        }
    }

    class SizeCheck : VMachinePart
    {
        public override void updateSensors()
        {

        }

        public override MachineParts? takeAction()
        {
            return null;
        }
    }

}
