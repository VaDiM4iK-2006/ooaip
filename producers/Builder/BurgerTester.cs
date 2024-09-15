using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BurgerTester
    {
        private IBurgerBuilder _builder;
        public BurgerTester(IBurgerBuilder builder)
        {
            _builder = builder;
        }
        void TestBurger()
        {
            try
            {
                _builder.AddMeat();
                _builder.AddSalad();
                _builder.AddPickles();
                _builder.AddTomato();
                _builder.AddBacon();
                _builder.AddSauce();
                _builder.AddCheese();
                _builder.AddOnion();
                _builder.AddVobla();
                Burger testBurger = _builder.MakeBurger();
                if (testBurger == null)
                {
                    throw new Exception("Error1");
                }
                if (!testBurger.Meat || !testBurger.Salad || !testBurger.Pickles || !testBurger.Tomato ||
                    !testBurger.Bacon || !testBurger.Sauce || !testBurger.Cheese || !testBurger.Onion ||
                    !testBurger.Vobla)
                {
                    throw new Exception("Error2");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
