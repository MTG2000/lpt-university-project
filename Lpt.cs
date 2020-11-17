using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    static class LPT
    {
        static byte Input;
        static byte Output;
        public static void setInput(byte i)
        {
            Input = i ;
        }
        public static byte getInput()
        {
            return Input;
        }
        public static void setOutput(byte o)
        {
            Output = o;
        }
        public static byte getOutput()
        {
            return Output;
        }

    }
}
