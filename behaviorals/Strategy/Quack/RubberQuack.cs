using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Quack
{
    public class RubberQuack : IQuack
    {
        public string Quack()
        {
            return "rubber duck is ...quacking";
        }
    }
}
