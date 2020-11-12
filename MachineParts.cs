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


    class FirstTrackStart : MachinePart
    {
        public void run(List<AppleInMachine> apples, AppleInMachine apple)
        {
            apple.location = MachineParts.CorruptionCheck;
        }
    }

    class CorruptionCheck : MachinePart
    {
        public void run(List<AppleInMachine> apples, AppleInMachine apple)
        {
            if (apple.apple.isCorrupted)
            {
                apple.location = MachineParts.CorruptedBasket;
                // Use the Pusher 
            }
            else
            {
                apple.location = MachineParts.FirstTrackEnd;
            }
        }
    }


    class CorruptedBasket : MachinePart
    {
        public void run(List<AppleInMachine> apples, AppleInMachine apple)
        {

            apple.toBeRemoved = true;
        }
    }

    class FirstTrackEnd : MachinePart
    {
        MachineParts part = MachineParts.FirstTrackEnd;
        public void run(List<AppleInMachine> apples, AppleInMachine apple)
        {
            apple.location = MachineParts.SizeCheck;
        }
    }

    class SizeCheck : MachinePart
    {
        MachineParts part = MachineParts.SizeCheck;
        public void run(List<AppleInMachine> apples, AppleInMachine apple)
        {
            if (apple.apple.size == AppleSize.Big) apple.location = MachineParts.BigSizeTrack;
            else apple.location = MachineParts.SmallSizeTrack;
        }
    }

    class BigSizeTrack : MachinePart
    {
        MachineParts part = MachineParts.BigSizeTrack;
        public void run(List<AppleInMachine> apples, AppleInMachine apple)
        {
            apple.location = MachineParts.BigBasket;
        }
    }

    class SmallSizeTrack : MachinePart
    {
        MachineParts part = MachineParts.SmallSizeTrack;
        public void run(List<AppleInMachine> apples, AppleInMachine apple)
        {
            apple.location = MachineParts.SmallBasket;
        }
    }

    class BigBasket : MachinePart
    {
        MachineParts part = MachineParts.BigBasket;
        public void run(List<AppleInMachine> apples, AppleInMachine apple)
        {
            apple.toBeRemoved = true;
        }
    }

    class SmallBasket : MachinePart
    {
        MachineParts part = MachineParts.SmallBasket;
        public void run(List<AppleInMachine> apples, AppleInMachine apple)
        {
            apple.toBeRemoved = true;
        }
    }
}
