using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builders;

namespace Builder.Directors
{
    public class ClientDirector
    {
        private IBurgerBuilder _builder;
        public ClientDirector(IBurgerBuilder builder)
        {
            if (builder == null) { throw new ArgumentNullException(); }
            _builder = builder;
        }
        public void CreateCustomBurger(IReadOnlyCollection<string> ingrList)
        {
            if (ingrList == null) { throw new ArgumentNullException(); }
            foreach (var ingr in ingrList)
            {
                switch (ingr)
                {
                    case "Meat": { _builder.AddMeat(); break; }
                    case "Cheese": { _builder.AddCheese(); break; }
                    case "Sause": { _builder.AddSauce(); break; }
                    case "Bacon": { _builder.AddBacon(); break; }
                    case "Onion": { _builder.AddOnion(); break; }
                    case "Pickles": { _builder.AddPickles(); break; }
                    case "Salad": { _builder.AddSalad(); break; }
                    case "Tomato": { _builder.AddTomato(); break; }
                    case "Vobla": { _builder.AddVobla(); break; }
                    default: break;
                }
            }
        }
    }
}
