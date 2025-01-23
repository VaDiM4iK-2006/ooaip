using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class NoCoinsState : IMachineState
    {
        public IMachineState AddCoin()
        {
            Console.WriteLine("coin has been inserted");
            return new YesCoinsState();
        }

        public IMachineState ReturnCoin()
        {
            Console.WriteLine("no coins to return");
            return this;
        }

        public IMachineState Spin()
        {
            Console.WriteLine("insert coin before spinning");
            return this;
        }

        public IMachineState PushBall()
        {
            Console.WriteLine("cannot push a ball");
            return this;
        }
    }
}
