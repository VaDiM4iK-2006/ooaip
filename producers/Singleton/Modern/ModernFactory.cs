using Singleton.HighTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Modern
{
    public class ModernFactory : IAbstractFactory
    {
        private static ModernFactory _instance;
        private ModernFactory() { }
        public static ModernFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ModernFactory();
                }
                return _instance;
            }
        }
        public IChair CreateChair()
        {
            return new ModernChair();
        }
        public ITable CreateTable()
        {
            return new ModernTable();
        }
        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
