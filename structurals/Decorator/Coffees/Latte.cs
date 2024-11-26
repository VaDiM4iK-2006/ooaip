using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Coffees
{
    public class Latte : ICoffee
    {
        public decimal Cost()
        {
            return 25;
        }
    }
}
