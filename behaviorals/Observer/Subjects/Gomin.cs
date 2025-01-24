using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subjects
{
    public class Gomin : ISubject
    {
        private readonly List<IObserver> _observerList = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observerList.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observerList?.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observerList)
            {
                observer.Update("Гомин");
            }
        }
    }
}
