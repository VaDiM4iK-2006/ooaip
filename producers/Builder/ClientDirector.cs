using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ClientDirector
    {
        private IBurgerBuilder _builder;
        private List<Action<IBurgerBuilder>> _ingredients;
        public ClientDirector(IBurgerBuilder builder)
        {
            _builder = builder;
            _ingredients = new List<Action<IBurgerBuilder>>();
        }
        public void AddIngredient(Action<IBurgerBuilder> ingredient)
        {
            _ingredients.Add(ingredient);
        }
        public void CreateCustomBurger()
        {
            foreach (var ingredient in _ingredients)
            {
                ingredient(_builder);
            }
        }
    }
}
