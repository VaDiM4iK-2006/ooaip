using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        public void AddMeat()
        {
            _burger.Meat = true;
        }
        public void AddSalad()
        {
            _burger.Salad = true;
        }
        public void AddPickles()
        {
            _burger.Pickles = true;
        }
        public void AddTomato()
        {
            _burger.Tomato = true;
        }
        public void AddBacon()
        {
            _burger.Bacon = true;
        }
        public void AddSauce()
        {
            _burger.Sauce = true;
        }
        public void AddCheese()
        {
            _burger.Cheese = true;
        }
        public void AddOnion()
        {
            _burger.Onion = true;
        }
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