using Decorator.Additives;
using Decorator.Coffees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Client
    {
        decimal BuyMocha()
        {
            return new Discount(new AddMilk(new AddSugar(new AddVanilla(new Mocha())))).Cost();
        }
        decimal BuyLatte()
        {
            return new Discount(new AddMilk(new AddSugar(new AddVanilla(new Latte())))).Cost();
        }
    }
}
