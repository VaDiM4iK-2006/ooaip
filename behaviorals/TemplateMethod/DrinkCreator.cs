namespace TemplateMethod
{
    public abstract class DrinkCreator
    {
        public void Cook()
        {
            BoilWater();
            Ingridients();
            IsSugar();
            AddSugar();
            Additions();
        }

        protected void BoilWater()
        {
            Console.WriteLine("water has been boiled");
        }

        protected abstract void Ingridients();

        protected abstract void IsSugar();

        protected void AddSugar()
        {
            Console.WriteLine("sugar has been added");
        }

        protected abstract void Additions();
    }
}
