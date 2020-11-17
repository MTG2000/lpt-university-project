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

            if (LPTWrapper.getOutput(0))
                return MachineParts.CorruptionCheck;

            return null;

        }

        public override void updateSensors()
        {
            //Activate Sensor if apple exist
            LPTWrapper.setInput(3, apple != null);
        }
    }

    class CorruptionCheck : VMachinePart
    {
        public override void updateSensors()
        {
            LPTWrapper.setInput(4, apple != null && apple.isCorrupted);

        }

        public override MachineParts? takeAction()
        {

            if (LPTWrapper.getOutput(1))
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
            if (apple == null)
            {

                LPTWrapper.setInput(5, false);
                LPTWrapper.setInput(6, false);
            } else if (apple.size == AppleSize.Big)
            {
                LPTWrapper.setInput(5, true);
                LPTWrapper.setInput(6, false);
            }
            else  
            {
                LPTWrapper.setInput(5, false);
                LPTWrapper.setInput(6, true);
            }
        }

        public override MachineParts? takeAction()
        {
            if (LPTWrapper.getOutput(2)) return MachineParts.BigSizeTrack;
            if (LPTWrapper.getOutput(3)) return MachineParts.SmallSizeTrack;
            return null;
        }
    }

    class BigSizeTrack : VMachinePart
    {
        public override void updateSensors()
        {
            
        }

        public override MachineParts? takeAction()
        {
           
            return MachineParts.BigBasket;
        }
    }

    class SmallSizeTrack : VMachinePart
    {
        public override void updateSensors()
        {

        }

        public override MachineParts? takeAction()
        {

            return MachineParts.SmallBasket;
        }
    }

    class BigBasket : VMachinePart
    {
        public override void updateSensors()
        {

        }

        public override MachineParts? takeAction()
        {
            return null;
        }
    }

    class SmallBasket : VMachinePart
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
