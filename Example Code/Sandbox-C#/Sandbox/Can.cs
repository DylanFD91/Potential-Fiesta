using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Can
    {
        // member variables (HAS A)
        public string color;
        public bool isOpen;
        public int percentageFull;

        // constructor (SPAWNER)
        public Can(string color)
        {
            this.color = color;
            isOpen = false;
            percentageFull = 100;
        }

        // member methods (CAN DO)
        public void Open()
        {
            isOpen = true;
        }
        public void TakeSip()
        {
            percentageFull -= 10;
        }
    }
}
