using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Machine
    {
        private IMachineState _state;

        public Machine()
        {
            _state = new NoCoinsState();
        }
        public void AddCoin()
        {
            _state = _state.AddCoin();
        }

        public void ReturnCoin()
        {
            _state = _state.ReturnCoin();
        }

        public void Spin()
        {
            _state = _state.Spin();
        }

        public void PushBall()
        {
            _state = _state.PushBall();
        }
    }
}
