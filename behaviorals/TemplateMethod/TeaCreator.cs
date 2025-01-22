using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class TeaCreator : DrinkCreator
    {
        protected override void Ingridients()
        {
            Console.WriteLine("adding tea to the water");
        }

        protected override void IsSugar()
        {
            Console.WriteLine("do you want sugar in your tea?");
        }

        protected override void Additions()
        {
            Console.WriteLine("adding lemon in the tea");
        }
    }
}
