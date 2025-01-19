using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class InputHandler : ViewOneHandler
    {
        private readonly IHandler _handler;

        public InputHandler(IHandler handler) : base(handler)
        {
            _handler = handler == null ? throw new ArgumentNullException() : handler;
        }

        public override string Handle(object handler, string type)
        {
            if (type == "Input")
            {
                return "success";
            }

            return base.Handle(handler, type);
        }
    }
}
