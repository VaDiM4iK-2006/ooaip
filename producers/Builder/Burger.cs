namespace Builder
{
    public class Burger
    {
        public List<string> Ingredients { get; set; }
        public Burger(List<string> ingrList)
        {
            Ingredients = ingrList;
        }
    }
}
