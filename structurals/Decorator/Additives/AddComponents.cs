using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Coffees;

namespace Decorator.Additives
{
    public abstract class AddComponents : ICoffee
    {
        protected ICoffee _coffee { get; }

        protected AddComponents(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public abstract decimal DoCost();

        public decimal Cost()
        {
            return Convert.ToDecimal(_coffee.Cost() + DoCost());
        }
    }
}
