using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.HighTech
{
    public class HighTechSofa : ISofa
    {
        public IPrototype Clone()
        {
            return new HighTechSofa();
        }
    }
}
