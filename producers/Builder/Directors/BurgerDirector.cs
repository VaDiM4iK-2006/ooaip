using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builders;

namespace Builder.Directors
{
    public class BurgerDirector
    {
        private IBurgerBuilder _builder;
        public BurgerDirector(IBurgerBuilder builder)
        {
            if (builder == null) { throw new ArgumentNullException(); }
            _builder = builder;
        }
        public void CreateBurger()
        {
            _builder.AddMeat();
            _builder.AddCheese();
            _builder.AddSauce();
            _builder.AddBacon();
            _builder.AddOnion();
            _builder.AddPickles();
            _builder.AddSalad();
            _builder.AddTomato();
            _builder.AddVobla();
        }
    }
}
