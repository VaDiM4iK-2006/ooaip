using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleagues
{
    public class CoffeeMachine : Colleague
    {
        public CoffeeMachine(IMediator mediator) : base(mediator) { }

        public void MakeCoffee()
        {
            
        }
    }
}
