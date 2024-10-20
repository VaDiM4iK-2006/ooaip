using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.HighTech
{
    public class HighTechChair : IChair
    {
        public IChair Clone() 
        { 
            return new HighTechChair();
        }
    }
}
