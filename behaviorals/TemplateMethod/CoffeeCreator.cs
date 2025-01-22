using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class CoffeeCreator : DrinkCreator
    {
        protected override void Ingridients()
        {
            Console.WriteLine("adding coffee to the water");
        }

        protected override void IsSugar()
        {
            Console.WriteLine("do you want sugar in your coffee?");
        }

        protected override void Additions()
        {
            Console.WriteLine("adding milk in the coffee");
        }
    }
}
