using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subscriber : IObserver
    {
        public string Update(string newspaper)
        {
            return newspaper + "aquired";
        }
    }
}
