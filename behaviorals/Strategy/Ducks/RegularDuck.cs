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
    public class RegularDuck : Duck
    {
        public RegularDuck() : base(new RegularFly(), new RegularSwim(), new RegularQuack())
        {
            
        }
    }
}
