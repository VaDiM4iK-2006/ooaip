using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Frog
{
    public class BrownFrog : IFrog
    {
        public string Croak()
        {
            return "croak...";
        }
    }
}
