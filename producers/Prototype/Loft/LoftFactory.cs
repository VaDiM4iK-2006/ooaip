using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Loft
{
    public class LoftFactory : IAbstractFactory
    {
        private IPrototype _protoChair;
        private IPrototype _protoTable;
        private IPrototype _protoSofa;
        public LoftFactory(IPrototype protoChair, IPrototype protoTable, IPrototype protoSofa)
        {
            _protoChair = protoChair;
            _protoTable = protoTable;
            _protoSofa = protoSofa;
        }
        public IPrototype CreateChair()
        {
            return new LoftChair();
        }
        public IPrototype CreateTable()
        {
            return new LoftTable();
        }
        public IPrototype CreateSofa()
        {
            return new LoftSofa();
        }
        public IPrototype CloneChair()
        {
            return _protoChair.Clone();
        }
        public IPrototype CloneTable()
        {
            return _protoChair.Clone();
        }
        public IPrototype CloneSofa()
        {
            return _protoChair.Clone();
        }
    }
}
