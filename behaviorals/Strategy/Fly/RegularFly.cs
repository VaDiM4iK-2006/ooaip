using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Fly
{
    public class RegularFly : IFly
    {
        public string Fly()
        {
            return "duck is flying";
        }
    }
}
