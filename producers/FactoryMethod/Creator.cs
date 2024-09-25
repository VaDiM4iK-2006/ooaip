using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Creator
    {
        protected abstract IChair CreateChair();
        protected abstract ITable CreateTable();
        protected abstract ISofa CreateSofa();

        public string ProcessChair()
        {
            var chair = CreateChair();
            return $"{chair}: success";
        }
        public string ProcessTable()
        {
            var table = CreateTable();
            return $"{table}: success";
        }
        public string ProcessSofa()
        {
            var sofa = CreateSofa();
            return $"{sofa}: success";
        }
    }
}
