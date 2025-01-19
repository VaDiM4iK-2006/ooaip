using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ButtonHandler : ViewOneHandler
    {
        private readonly IHandler _handler;

        public ButtonHandler(IHandler handler) : base(handler)
        {
            _handler = handler == null ? throw new ArgumentNullException() : handler;
        }

        public override string Handle(object handler, string type)
        {
            if (type == "Button")
            {
                return "success";
            }

            return base.Handle(handler, type);
        }
    }
}
