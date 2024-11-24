using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface ITV
    {
        public string WorkStatus(bool status);
        public string SetChannel(int channel_number);
    }
}
