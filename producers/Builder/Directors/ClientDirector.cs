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
        public void CreateCustomBurger()
        {
            if(Choise("Meat")) _builder.AddMeat();
            if(Choise("Cheese")) _builder.AddCheese();
            if(Choise("Sauce")) _builder.AddSauce();
            if(Choise("Bacon")) _builder.AddBacon();
            if(Choise("Onion")) _builder.AddOnion();
            if(Choise("Pickles")) _builder.AddPickles();
            if(Choise("Salad")) _builder.AddSalad();
            if(Choise("Tomato")) _builder.AddTomato();
            if(Choise("Vobla")) _builder.AddVobla();
        }
        private bool Choise(string ingr)
        {
            Console.WriteLine($"Add {ingr}? | 0 - n, 1 - y");
            int answer = Convert.ToInt32( Console.ReadLine() );
            return answer != 0;
        }
    }
}
