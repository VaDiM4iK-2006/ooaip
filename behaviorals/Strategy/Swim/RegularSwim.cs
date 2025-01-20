using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Swim
{
    public class RegularSwim : ISwim
    {
        public string Swim()
        {
            return "duck is swimming";
        }
    }
}
