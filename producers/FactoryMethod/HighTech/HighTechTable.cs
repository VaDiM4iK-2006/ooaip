using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.HighTech
{
    public class HighTechTable : ITable
    {
        public string Result()
        {
            return "high-tech table";
        }
    }
}
