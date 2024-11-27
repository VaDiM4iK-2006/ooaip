using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : IComponent
    {
        List<IComponent> _componentList = new List<IComponent>();
        public void AddComponent(IComponent component)
        {
            _componentList.Add(component);
        }

        public IEnumerable<double> GetValue()
        {
            foreach (var component in _componentList)
            {
                foreach(var value in component.GetValue())
                {
                    yield return value;
                }
            }
        }
    }
}
