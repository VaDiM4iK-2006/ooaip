using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class WierdBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        public void AddMeat() { }
        public void AddSalad() { }
        public void AddPickles() { }
        public void AddTomato() { }
        public void AddBacon() { }
        public void AddSauce() { }
        public void AddCheese() { }
        public void AddOnion() { }
        public void AddVobla()
        {
            _burger.Vobla = true;
        }
        public Burger MakeBurger()
        {
            Burger burger = _burger;
            _burger = new();
            return burger;
        }
    }
}