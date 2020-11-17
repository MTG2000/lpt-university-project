using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class VirtualMachine
    {
        Dictionary<MachineParts, VMachinePart> parts = new Dictionary<MachineParts, VMachinePart> {
            { MachineParts.FirstTrackStart ,new FirstTrackStart() },
            { MachineParts.CorruptionCheck ,new CorruptionCheck() },
            { MachineParts.CorruptedBasket ,new CorruptedBasket() },
            { MachineParts.FirstTrackEnd ,new FirstTrackEnd() },
            { MachineParts.SizeCheck ,new SizeCheck() },
            { MachineParts.BigSizeTrack ,new BigSizeTrack() },
            { MachineParts.SmallSizeTrack ,new SmallSizeTrack() },
            { MachineParts.BigBasket ,new BigBasket() },
            { MachineParts.SmallBasket ,new SmallBasket() },

        };

        public Dictionary<MachineParts, VMachinePart> Parts { get => parts; }

        public void addApple(Apple apple)
        {
            parts[MachineParts.FirstTrackStart].apple = apple;
        }

        public void run()
        {
            Dictionary<MachineParts, Apple> newLocations = new Dictionary<MachineParts, Apple>();

            // check all sensors and (de)activate according to apples states

            foreach (var part in parts.Values)
            {
                part.updateSensors();
            }

            // Call The Program so that it reacts to sensors changes and changes the outputs

            MachineProgram.run();


            // Move the apples to the next part according to Program Orders

            foreach (var part in parts.Values)
            {
                var newLocation = part.takeAction();
                if (newLocation.HasValue)
                {
                    newLocations.Add((MachineParts)newLocation, part.apple);
                }
                part.apple = null;

            }



            foreach (var loc in newLocations)
            {
                parts[loc.Key].apple = loc.Value;
            }


        }
    }

}
