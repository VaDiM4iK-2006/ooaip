using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.HighTech
{
    public class HighTechFactory : IAbstractFactory
    {
        private IPrototype _protoChair;
        private IPrototype _protoTable;
        private IPrototype _protoSofa;
        public HighTechFactory(IPrototype protoChair, IPrototype protoTable, IPrototype protoSofa)
        {
            _protoChair = protoChair;
            _protoTable = protoTable;
            _protoSofa = protoSofa;
        }
        public IPrototype CreateChair()
        {
            return new HighTechChair();
        }
        public IPrototype CreateTable()
        {
            return new HighTechTable();
        }
        public IPrototype CreateSofa()
        {
            return new HighTechSofa();
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
