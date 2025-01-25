using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleagues
{
    public class Clock : Colleague
    {
        public Clock(IMediator mediator) : base(mediator) { }

        public void ClockHandler()
        {
            for (int i = 0; i < 24; i++)
            {
                _mediator.Notify("clock", i);
            }
            
        }
    }
}
