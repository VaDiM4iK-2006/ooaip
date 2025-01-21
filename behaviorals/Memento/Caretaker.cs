using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        private readonly List<IMemento> _mementoList = new List<IMemento>();

        public void SaveState(IMemento memento)
        {
            _mementoList.Add(memento);
        }

        public IMemento GetLastState()
        {
            if (_mementoList.Count == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return _mementoList.Last();
            }
        }
    }
}