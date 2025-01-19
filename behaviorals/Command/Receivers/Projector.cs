using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Projector
    {
        private bool state = false;
        public string OnOff()
        {
            state = !state;
            if (state)
            {
                return "Projector is turned on..";
            }
            return "Projector is turned off.";
        }
    }
}
