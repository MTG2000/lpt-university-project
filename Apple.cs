using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{

    enum AppleSize { Big,Small};
    class Apple
    {
        public readonly AppleSize size; 
        public readonly bool isCorrupted;

        public Apple(AppleSize size, bool isCourrpted)
        {
            this.size = size;
            this.isCorrupted = isCourrpted;
        }
    }
}
