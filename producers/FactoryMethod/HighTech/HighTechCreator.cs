using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.HighTech
{
    public class HighTechCreator : Creator
    {
        protected override IChair CreateChair()
        {
            return new HighTechChair();
        }
        protected override ITable CreateTable()
        {
            return new HighTechTable();
        }
        protected override ISofa CreateSofa()
        {
            return new HighTechSofa();
        }
    }
}
