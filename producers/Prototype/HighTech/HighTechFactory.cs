using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.HighTech
{
    public class HighTechFactory : IAbstractFactory
    {
        private IChair _protoChair;
        private ITable _protoTable;
        private ISofa _protoSofa;
        public HighTechFactory(HighTechChair protoChair, HighTechTable protoTable, HighTechSofa protoSofa)
        {
            _protoChair = protoChair;
            _protoTable = protoTable;
            _protoSofa = protoSofa;
        }
        public IChair CreateChair()
        {
            return _protoChair.Clone();
        }
        public ITable CreateTable()
        {
            return _protoTable.Clone();
        }
        public ISofa CreateSofa()
        {
            return _protoSofa.Clone();
        }
        
    }
}
