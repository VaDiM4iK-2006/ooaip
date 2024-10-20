using Prototype.Loft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Client
    {
        public Client()
        {
            var loftChair = new LoftChair();
            var loftTable = new LoftTable();
            var loftSofa = new LoftSofa();

            var loftFactory = new LoftFactory(loftChair, loftTable, loftSofa);

            var loftChairClone = loftFactory.CreateChair();
            var loftTableClone = loftFactory.CreateTable();
            var loftSofaClone = loftFactory.CreateSofa();
        }
    }
}
