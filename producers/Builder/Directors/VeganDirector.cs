using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builders;

namespace Builder.Directors
{
    public class VeganDirector
    {
        private IBurgerBuilder _builder;
        public VeganDirector(IBurgerBuilder builder)
        {
            if (builder == null) { throw new ArgumentNullException(); }
            _builder = builder;
        }
        public void CreateVeganBurger()
        {
            _builder.AddSauce();
            _builder.AddOnion();
            _builder.AddPickles();
            _builder.AddSalad();
            _builder.AddTomato();
        }
    }
}
