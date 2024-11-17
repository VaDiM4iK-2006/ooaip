using System.Collections.ObjectModel;

namespace Builder
{
    public class Burger
    {
        public IReadOnlyCollection<string> Ingredients { get; }
        public Burger(IReadOnlyCollection<string> ingrList)
        {
            Ingredients = ingrList;
        }
    }
}
