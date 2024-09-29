using Singleton.HighTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Loft
{
    public class LoftFactory : IAbstractFactory
    {
        private static LoftFactory _instance;
        private LoftFactory() { }
        public static LoftFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoftFactory();
                }
                return _instance;
            }
        }
        public IChair CreateChair()
        {
            return new LoftChair();
        }
        public ITable CreateTable()
        {
            return new LoftTable();
        }
        public ISofa CreateSofa()
        {
            return new LoftSofa();
        }
    }
}
