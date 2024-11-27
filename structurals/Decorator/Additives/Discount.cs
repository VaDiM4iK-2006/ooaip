using Decorator.Coffees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Additives
{
    public class Discount : AddComponents
    {
        public Discount(ICoffee coffee) : base(coffee) { }

        public override decimal DoCost()
        {
            return _coffee.Cost() * -0.1m;
        }
    }
}
