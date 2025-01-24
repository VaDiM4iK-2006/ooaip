using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subjects
{
    public class Caravan : ISubject
    {
        public event Action<string> Publication;

        public void Attach(IObserver observer)
        {
            Publication += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            Publication -= observer.Update;
        }

        public void Notify()
        {
            Publication?.Invoke("Караван");
        }
    }
}
