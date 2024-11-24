using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class OldTV : ITV
    {
        public string WorkStatus(bool status)
        {
            if (status) return "tv is working...";
            return "...";
        }
        public string SetChannel(int channel_number)
        {
            return $"channel№{channel_number} is on...";
        }
    }
}
