using Adapter.Duck;
using Adapter.Frog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FrogToDuckAdapter : IDuck
    {
        private IFrog _adapteeFrog;

        public FrogToDuckAdapter(IFrog adapteeFrog)
        {
            _adapteeFrog = adapteeFrog == null ? throw new ArgumentNullException() : adapteeFrog;
        }

        public string Quack()
        {
            return _adapteeFrog.Croak();
        }
    }
}
