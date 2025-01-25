using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleagues
{
    public class IrrigationSystem : Colleague
    {
        public IrrigationSystem(IMediator mediator) : base(mediator) { }

        public void Irrigate()
        {

        }
    }
}
