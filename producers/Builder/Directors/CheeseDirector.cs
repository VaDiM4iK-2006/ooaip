using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builders;

namespace Builder.Directors
{
    public class CheeseDirector
    {
        private IBurgerBuilder _builder;
        public CheeseDirector(IBurgerBuilder builder)
        {
            if (builder == null) { throw new ArgumentNullException(); }
            _builder = builder;
        }
        public void CreateCheeseBurger()
        {
            _builder.AddMeat();
            _builder.AddCheese();
            _builder.AddSauce();
            _builder.AddOnion();
            _builder.AddPickles();
            _builder.AddTomato();
        }
    }
}
