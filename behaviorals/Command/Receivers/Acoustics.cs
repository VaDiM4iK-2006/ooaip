using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Acoustics
    {
        private bool state = false;
        public string OnOff()
        {
            state = !state;
            if (state)
            {
                return "Acoustics is turned on..";
            }
            return "Acoustics is turned off.";
        }
    }
}
