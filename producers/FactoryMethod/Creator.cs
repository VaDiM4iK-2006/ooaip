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
    }
}
