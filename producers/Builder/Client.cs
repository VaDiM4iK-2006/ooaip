using Builder.Builders;
using Builder.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Client
    {
        public Client(MenuBuilder menu, TestBurgerBuilder tester) 
        {
            BurgerBuilder builder = new BurgerBuilder();
            Console.WriteLine(menu.ShowMenu());
            var burger = new ClientDirector(builder);
            burger.CreateCustomBurger();
            if (tester.TestBurger() == false)
            {
                Console.WriteLine("error");
            }
        }
    }
}
