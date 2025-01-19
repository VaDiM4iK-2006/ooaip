using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Light
    {
        private bool state = false;
        public string OnOff()
        {
            state = !state;
            if (state)
            {
                return "light is turned on..";
            }
            return "light is turned off.";
        }
    }
}
