using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{



    class AppleInMachine
    {
        Guid id;
        public readonly Apple apple;
        public bool toBeRemoved = false;
        public MachineParts location = MachineParts.FirstTrackStart;

        public AppleInMachine(Apple apple)
        {
            id = Guid.NewGuid();
            this.apple = apple;
        }
    }

    class Machine
    {
        List<AppleInMachine> apples = new List<AppleInMachine>();

        public List<AppleInMachine> Apples { get => apples; }

        public void addApple(AppleSize size, bool isCorrupted)
        {
            if (apples.Count == 0 || apples.Last().location != MachineParts.FirstTrackStart)
                apples.Add(new AppleInMachine(new Apple(size, isCorrupted)));
            // Re-Activate First Track for right interval 
        }


        public void run()
        {
            foreach (var apple in apples)
            {
                switch (apple.location)
                {
                    case MachineParts.FirstTrackStart:
                        new FirstTrackStart().run(apples, apple);
                        break;
                    case MachineParts.CorruptionCheck:
                        new CorruptionCheck().run(apples, apple);
                        break;
                    case MachineParts.CorruptedBasket:
                        new CorruptedBasket().run(apples, apple);
                        break;
                    case MachineParts.FirstTrackEnd:
                        new FirstTrackEnd().run(apples, apple);
                        break;
                    case MachineParts.SizeCheck:
                        new SizeCheck().run(apples, apple);
                        break;
                    case MachineParts.BigSizeTrack:
                        new BigSizeTrack().run(apples, apple);
                        break;
                    case MachineParts.SmallSizeTrack:
                        new SmallSizeTrack().run(apples, apple);
                        break;
                    case MachineParts.BigBasket:
                        new BigBasket().run(apples, apple);
                        break;
                    case MachineParts.SmallBasket:
                        new SmallBasket().run(apples, apple);
                        break;
                    default:
                        break;
                }
            }

            for (int i = apples.Count - 1; i > -1; i--)
            {
                if (apples[i].toBeRemoved)
                {
                    apples.RemoveAt(i);
                }
            }
        }

    }

}
