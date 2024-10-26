using System.Collections.ObjectModel;

namespace Builder
{
    public class Burger
    {
        public ReadOnlyCollection<string> Ingredients { get; }
        public Burger(ReadOnlyCollection<string> ingrList)
        {
            Ingredients = ingrList;
        }
    }
}
