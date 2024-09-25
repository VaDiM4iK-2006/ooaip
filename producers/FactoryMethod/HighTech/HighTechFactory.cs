using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.HighTech
{
    public class HighTechFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new HighTechChair();
        }
        public ITable CreateTable()
        {
            return new HighTechTable();
        }
        public ISofa CreateSofa()
        {
            return new HighTechSofa();
        }
    }
}
