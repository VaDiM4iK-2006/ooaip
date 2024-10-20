using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Loft
{
    public class LoftTable : ITable
    {
        public ITable Clone()
        {
            return new LoftTable();
        }
    }
}
