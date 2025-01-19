using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ViewTwoHandler : WindowHandler
    {
        private readonly IHandler _handler;

        public ViewTwoHandler(IHandler handler) : base(handler)
        {
            _handler = handler == null ? throw new ArgumentNullException() : handler;
        }

        public override string Handle(object handler, string type)
        {
            if (type == "ViewTwo")
            {
                return "success";
            }

            return base.Handle(handler, type);
        }
    }
}
