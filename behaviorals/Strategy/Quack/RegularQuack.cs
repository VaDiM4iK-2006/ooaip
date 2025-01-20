using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Quack
{
    public class RegularQuack : IQuack
    {
        public string Quack()
        {
            return "duck is quacking";
        }
    }
}
