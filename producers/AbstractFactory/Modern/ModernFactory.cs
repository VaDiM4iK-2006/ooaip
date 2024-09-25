using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Modern
{
    public class ModernFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }
        public ITable CreateTable()
        {
            return new ModernTable();
        }
        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
