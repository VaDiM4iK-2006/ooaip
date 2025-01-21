using Strategy.Fly;
using Strategy.Quack;
using Strategy.Swim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public class MechanicalDuck : Duck
    {
        public MechanicalDuck() : base(new RocketFly(), new RegularSwim(), new RegularQuack())
        {
            
        }
    }
}
