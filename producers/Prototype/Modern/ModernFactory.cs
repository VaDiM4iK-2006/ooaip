using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modern
{
    public class ModernFactory : IAbstractFactory
    {
        private IChair _protoChair;
        private ITable _protoTable;
        private ISofa _protoSofa;
        public ModernFactory(ModernChair protoChair, ModernTable protoTable, ModernSofa protoSofa)
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
