using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mediator.Colleagues
{
    public class Calendar : Colleague
    {
        public Calendar(IMediator mediator) : base(mediator) { }

        public void CalendarHandler()
        {
            for (int i = 0; i < 7; i++)
            {
                _mediator.Notify("calendar", i);
            }
        }
    }
}
