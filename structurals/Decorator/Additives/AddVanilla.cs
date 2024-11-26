using Decorator.Coffees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Additives
{
    public class AddVanilla : AddComponents
    {
        public AddVanilla(ICoffee coffee) : base(coffee) { }
        public override decimal DoCost()
        {
            return 10;
        }
    }
}
