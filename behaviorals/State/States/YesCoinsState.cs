using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class YesCoinsState : IMachineState
    {
        public IMachineState AddCoin()
        {
            Console.WriteLine("coin is already inserted");
            return this;
        }

        public IMachineState ReturnCoin()
        {
            Console.WriteLine("returning coin");
            return new NoCoinsState();
        }

        public IMachineState Spin()
        {
            Console.WriteLine("started spinning the machine");
            return new SpinningState();
        }

        public IMachineState PushBall()
        {
            Console.WriteLine("wait for spin to finish");
            return this;
        }
    }
}
