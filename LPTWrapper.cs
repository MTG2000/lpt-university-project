using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class LPTWrapper
    {
        public static bool getInput(int index)
        {
            byte input = LPT.getInput();
            switch (index)
            {
                case 3:
                    if ((input &= 0x08) == 0x08)
                        return true;
                    else return false;
                case 4:
                    if ((input &= 0x10) == 0x10)
                        return true;
                    else return false;
                case 5:
                    if ((input &= 0x20) == 0x20)
                        return true;
                    else return false;
                case 6:
                    if ((input &= 0x30) == 0x30)
                        return true;
                    else return false;
                case 7:
                    if ((input &= 0x40) == 0x40)
                        return true;
                    else return false;
                default: return false;
            }
        }
        public static void setInput(int index,bool data)
        {
            byte oldInput = LPT.getInput();
            if (data)
            {
                
                switch (index)
                {
                    case 3:
                        oldInput |= 0x08;
                        LPT.setInput(oldInput);
                        break;
                    case 4:
                        oldInput |= 0x10;
                        LPT.setInput(oldInput);
                        break;
                    case 5:
                        oldInput |= 0x20;
                        LPT.setInput(oldInput);
                        break;
                    case 6:
                        oldInput |= 0x30;
                        LPT.setInput(oldInput);
                        break;
                    case 7:
                        oldInput |= 0x40;
                        LPT.setInput(oldInput);
                        break;
                }
            }else
            {
                switch (index)
                {
                    case 3:
                        oldInput &= 0xf7;
                        LPT.setInput(oldInput);
                        break;
                    case 4:
                        oldInput &= 0xEF;
                        LPT.setInput(oldInput);
                        break;
                    case 5:
                        oldInput &= 0xdf;
                        LPT.setInput(oldInput);
                        break;
                    case 6:
                        oldInput &= 0xbf;
                        LPT.setInput(oldInput);
                        break;
                    case 7:
                        oldInput &= 0x7f;
                        LPT.setInput(oldInput);
                        break;
                }
            }
        }
        public static bool getOutput(int index)
        {
            byte output = LPT.getOutput();
            switch (index)
            {
                case 0:
                    if ((output &= 0x01) == 0x01)
                        return true;
                    else return false;
                case 1:
                    if ((output &= 0x02) == 0x02)
                        return true;
                    else return false;
                case 2:
                    if ((output &= 0x04) == 0x04)
                        return true;
                    else return false;
                case 3:
                    if ((output &= 0x08) == 0x08)
                        return true;
                    else return false;
                default: return false;
            }
        }
        public static void setOutput(int index, bool data)
        {
            byte oldOutput = LPT.getOutput();
            if (data)
            {

                switch (index)
                {
                    case 0:
                        oldOutput |= 0x01;
                        LPT.setOutput(oldOutput);
                        break;
                    case 1:
                        oldOutput |= 0x02;
                        LPT.setOutput(oldOutput);
                        break;
                    case 2:
                        oldOutput |= 0x04;
                        LPT.setOutput(oldOutput);
                        break;
                    case 3:
                        oldOutput |= 0x08;
                        LPT.setOutput(oldOutput);
                        break;

                }
            }
            else
            {
                switch (index)
                {
                    case 0:
                        oldOutput &= 0xfe;
                        LPT.setOutput(oldOutput);
                        break;
                    case 1:
                        oldOutput &= 0xfd;
                        LPT.setOutput(oldOutput);
                        break;
                    case 2:
                        oldOutput &= 0xfb;
                        LPT.setOutput(oldOutput);
                        break;
                    case 3:
                        oldOutput &= 0xf7;
                        LPT.setOutput(oldOutput);
                        break;
                    
                }
            }
        }
    }
}
