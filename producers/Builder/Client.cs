using Builder.Builders;
using Builder.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Builder
{
    public class Client
    {
        public Client(MenuBuilder menuBuilder, TestBurgerBuilder tester) 
        {
            BurgerBuilder builder = new BurgerBuilder();
            IReadOnlyCollection<string> Menu = menuBuilder.ShowMenu();
            var burger = new ClientDirector(builder);
            burger.CreateCustomBurger(Menu);
            if (tester.TestBurger() == false)
            {
                Console.WriteLine("error");
            }
        }
    }
}
