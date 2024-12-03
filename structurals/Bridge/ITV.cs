using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface ITV
    {
        string WorkStatus(bool status);
        string SetChannel(int channelNumber);
    }
}
