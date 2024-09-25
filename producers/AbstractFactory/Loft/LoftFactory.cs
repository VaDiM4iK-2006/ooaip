using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Loft
{
    public class LoftFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new LoftChair();
        }
        public ITable CreateTable()
        {
            return new LoftTable();
        }
        public ISofa CreateSofa()
        {
            return new LoftSofa();
        }
    }
}
