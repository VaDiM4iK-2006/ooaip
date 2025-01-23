using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class PushBallState : IMachineState
    {
        public IMachineState AddCoin()
        {
            Console.WriteLine("wait for ball to get pushed out of the machine");
            return this;
        }

        public IMachineState ReturnCoin()
        {
            Console.WriteLine("coin is already spent");
            return this;
        }

        public IMachineState Spin()
        {
            Console.WriteLine("wait for ball to get pushed out of the machine");
            return this;
        }

        public IMachineState PushBall()
        {
            Console.WriteLine("here's your ball...");
            return new NoCoinsState();
        }
    }
}
