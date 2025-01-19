using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Screen
    {
        private bool state = true;
        public string UpDown()
        {
            state = !state;
            if (state)
            {
                return "Screen is moved up";
            }
            return "Screen is moved down.";
        }
    }
}
