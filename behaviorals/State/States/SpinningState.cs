using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class SpinningState : IMachineState
    {
        public IMachineState AddCoin()
        {
            Console.WriteLine("wait for spin to finish");
            return this;
        }

        public IMachineState ReturnCoin()
        {
            Console.WriteLine("too late to return coin!");
            return this;
        }

        public IMachineState Spin()
        {
            Console.WriteLine("machine is already spinning");
            return this;
        }

        public IMachineState PushBall()
        {
            Console.WriteLine("pushing the ball");
            return new PushBallState();
        }
    }
}
