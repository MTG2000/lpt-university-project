using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Lpt
    {
        static public string ins= "00000000", outs= "00000000";

    

        static public void setInputs(int index, bool value)
        {
            outs.ToCharArray()[index] = value ? '1' : '0';
        }

        static public bool getOutputs(int index)
        {
            if (index >= 0 && index < ins.Length)
                return ins[index] == 1;
            return false;
        }
    }
}
