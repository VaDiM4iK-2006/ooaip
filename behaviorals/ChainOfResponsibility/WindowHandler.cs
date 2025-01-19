using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class WindowHandler : IHandler
    {
        private readonly IHandler _handler;

        public WindowHandler(IHandler handler)
        {
            _handler = handler == null ? throw new ArgumentNullException() : handler;
        }

        public virtual string Handle(object handler, string type)
        {
            if (handler != null)
            {
                return _handler.Handle(handler, type);
            }

            return "no suitable handlers";
        }
    }
}
