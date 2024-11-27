using Decorator.Coffees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Additives
{
    public class AddMilk : AddComponents
    {
        public AddMilk(ICoffee coffee) : base(coffee) { }

        public override decimal DoCost()
        {
            return 15;
        }
    }
}
