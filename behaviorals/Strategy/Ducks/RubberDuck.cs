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
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new NoFly(), new RegularSwim(), new RubberQuack())
        {
            
        }
    }
}
