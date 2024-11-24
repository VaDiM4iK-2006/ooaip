using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Client
    {
        void WatchTV()
        {
            var tv = new PlasmaTV();
            var remote = new ConcreteRemote(tv);
            remote.TurnOn();
            remote.SetChannel(6);
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.NextChannel();
            remote.TurnOff();
        }
    }
}
