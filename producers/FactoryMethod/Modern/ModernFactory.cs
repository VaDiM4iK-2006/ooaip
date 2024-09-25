using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Modern
{
    public class ModernCreator : Creator
    {
        protected override IChair CreateChair()
        {
            return new ModernChair();
        }
        protected override ITable CreateTable()
        {
            return new ModernTable();
        }
        protected override ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
