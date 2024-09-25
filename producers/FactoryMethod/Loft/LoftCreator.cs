using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Loft
{
    public class LoftCreator : Creator
    {
        protected override IChair CreateChair()
        {
            return new LoftChair();
        }
        protected override ITable CreateTable()
        {
            return new LoftTable();
        }
        protected override ISofa CreateSofa()
        {
            return new LoftSofa();
        }
    }
}
