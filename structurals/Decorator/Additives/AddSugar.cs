using Decorator.Coffees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Additives
{
    public class AddSugar : AddComponents
    {
        public AddSugar(ICoffee coffee) : base(coffee) { }

        public override decimal DoCost()
        {
            return 5;
        }
    }
}
