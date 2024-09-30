using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Client
    {
        private IPrototype _chair;
        private IPrototype _table;
        private IPrototype _sofa;
        private IPrototype _chairClone;
        private IPrototype _tableClone;
        private IPrototype _sofaClone;

        public Client(IAbstractFactory factory)
        {
            _chair = factory.CreateChair();
            _table = factory.CreateTable();
            _sofa = factory.CreateSofa();
            _chairClone = _chair.Clone();
            _tableClone = _table.Clone();
            _sofaClone = _sofa.Clone();
        }
    }
}
