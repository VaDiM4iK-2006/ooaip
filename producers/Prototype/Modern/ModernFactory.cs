using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modern
{
    public class ModernFactory : IAbstractFactory
    {
        private IPrototype _protoChair;
        private IPrototype _protoTable;
        private IPrototype _protoSofa;
        public ModernFactory(IPrototype protoChair, IPrototype protoTable, IPrototype protoSofa)
        {
            _protoChair = protoChair;
            _protoTable = protoTable;
            _protoSofa = protoSofa;
        }
        public IPrototype CreateChair()
        {
            return new ModernChair();
        }
        public IPrototype CreateTable()
        {
            return new ModernTable();
        }
        public IPrototype CreateSofa()
        {
            return new ModernSofa();
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
