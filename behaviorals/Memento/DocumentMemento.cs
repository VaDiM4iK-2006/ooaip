using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class DocumentMemento : IMemento
    {
        private DateTime _date;
        private string _state;

        public DocumentMemento(string state)
        {
            _date = DateTime.Now;
            _state = state == null ? throw new ArgumentNullException() : state;
        }

        public DateTime Date()
        {
            return _date;
        }
        public string GetState()
        {
            return _state;
        }

        public void SetState(string state)
        {
            _state = state == null ? throw new ArgumentNullException() : state;
        }
    }
}
