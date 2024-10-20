using System;
using System.Collections.Generic;
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
            _builder = builder;
        }
        public void CreateCustomBurger(string ingrList)
        {
            if (ingrList.Contains("Meat")) _builder.AddMeat();
            if (ingrList.Contains("Cheese")) _builder.AddCheese();
            if (ingrList.Contains("Sause")) _builder.AddSauce();
            if (ingrList.Contains("Bacon")) _builder.AddBacon();
            if (ingrList.Contains("Onion")) _builder.AddOnion();
            if (ingrList.Contains("Pickles")) _builder.AddPickles();
            if (ingrList.Contains("Salad")) _builder.AddSalad();
            if (ingrList.Contains("Tomato")) _builder.AddTomato();
            if (ingrList.Contains("Vobla")) _builder.AddVobla();
        }
        private bool Choise(string ingr)
        {
            Console.WriteLine($"Add {ingr}? | 0 - n, 1 - y");
            int answer = Convert.ToInt32( Console.ReadLine() );
            return answer != 0;
        }
    }
}
