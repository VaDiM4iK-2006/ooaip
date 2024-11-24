using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf : IComponent
    {
        private double _value;
        public Leaf(double value)
        {
            _value = value;
        }
        public IEnumerable<double> GetValue()
        {
            yield return _value;
        }
    }
}
