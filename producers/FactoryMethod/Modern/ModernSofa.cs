using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Modern
{
    public class ModernSofa : ISofa
    {
        public string Result()
        {
            return "modern sofa";
        }
    }
}
