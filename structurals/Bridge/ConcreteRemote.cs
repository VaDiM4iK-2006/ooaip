using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ConcreteRemote : Remote
    {
        private int selectedChannel = 1;
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
            selectedChannel = number;
            _tv.SetChannel(number);
        }

        public void NextChannel()
        {
            selectedChannel++;
            _tv.SetChannel(selectedChannel);
        }

        public void PrevChannel()
        {
            selectedChannel--;
            _tv.SetChannel(selectedChannel);
        }
    }
}
