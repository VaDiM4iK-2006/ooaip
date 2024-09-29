using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.HighTech
{
    public class HighTechFactory : IAbstractFactory
    {
        private static HighTechFactory _instance;
        private HighTechFactory() { }
        public static HighTechFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HighTechFactory();
                }
                return _instance;
            }
        }
        public IChair CreateChair()
        {
            return new HighTechChair();
        }
        public ITable CreateTable()
        {
            return new HighTechTable();
        }
        public ISofa CreateSofa()
        {
            return new HighTechSofa();
        }
    }
}
