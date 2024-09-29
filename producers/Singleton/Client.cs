using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Client
    {
        private IChair _chair;
        private ITable _table;
        private ISofa _sofa;

        public Client(IAbstractFactory factory)
        {
            _chair = factory.CreateChair();
            _table = factory.CreateTable();
            _sofa = factory.CreateSofa();
        }
    }
}
