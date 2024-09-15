using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private IBurgerBuilder _builder;
        public Director(IBurgerBuilder builder)
        {
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
        }
    }
}
