using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ConcreteRemote : Remote
    {
        int selected_channel = 1;
        public ConcreteRemote(ITV tv) : base(tv) { }
        public override void TurnOn()
        {
            _tv.WorkStatus(true);
        }
        public override void TurnOff()
        {
            _tv.WorkStatus(false);
        }
        public override void SetChannel(int number)
        {
            selected_channel = number;
            _tv.SetChannel(number);
        }
        public void NextChannel()
        {
            selected_channel++;
            _tv.SetChannel(selected_channel);
        }
        public void PrevChannel()
        {
            selected_channel--;
            _tv.SetChannel(selected_channel);
        }
    }
}
