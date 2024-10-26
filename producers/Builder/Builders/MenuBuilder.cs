using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class MenuBuilder : IBurgerBuilder
    {
        private List<string> _ingrList;
        public MenuBuilder()
        {
            _ingrList = new List<string>();
        }
        public void AddMeat()
        {
            _ingrList.Add("Meat");
        }
        public void AddSalad()
        {
            _ingrList.Add("Salad");
        }
        public void AddPickles()
        {
            _ingrList.Add("Pickles");
        }
        public void AddTomato()
        {
            _ingrList.Add("Tomato");
        }
        public void AddBacon()
        {
            _ingrList.Add("Bacon");
        }
        public void AddSauce()
        {
            _ingrList.Add("Sauce");
        }
        public void AddCheese()
        {
            _ingrList.Add("Cheese");
        }
        public void AddOnion()
        {
            _ingrList.Add("Onion");
        }
        public void AddVobla()
        {
            _ingrList.Add("Vobla");
        }
        public ReadOnlyCollection<string> ShowMenu()
        {
            return new ReadOnlyCollection<string>(_ingrList);
        }
    }
}