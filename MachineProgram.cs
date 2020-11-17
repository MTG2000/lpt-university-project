using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class MachineProgram
    {
        public static void run()
        {
            if (LPTWrapper.getInput(3))
            {
                LPTWrapper.setOutput(0, true);
            }
            else LPTWrapper.setOutput(0, false);

            if (LPTWrapper.getInput(4))
            {
                LPTWrapper.setOutput(1, true);
            }
            else LPTWrapper.setOutput(1, false);

            //Big Apple
            if (LPTWrapper.getInput(5) && !LPTWrapper.getInput(6))
            {
                LPTWrapper.setOutput(2, true);
                LPTWrapper.setOutput(3, false);
            }
            // Small Apple
            else if (LPTWrapper.getInput(6) && !LPTWrapper.getInput(5))
            {
                LPTWrapper.setOutput(2, false);
                LPTWrapper.setOutput(3, true);
            }
            // No Apple
            else
            {
                LPTWrapper.setOutput(2, false);
                LPTWrapper.setOutput(3, false);
            }

        }
    }
}
