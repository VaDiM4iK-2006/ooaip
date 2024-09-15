using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HTFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new HTChair();
        }
        public ITable CreateTable()
        {
            return new HTTable();
        }
        public ISofa CreateSofa()
        {
            return new HTSofa();
        }
    }
}
