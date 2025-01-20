using Strategy.Fly;
using Strategy.Quack;
using Strategy.Swim;

namespace Strategy.Ducks
{
    public abstract class Duck
    {
        protected IFly _fly { get; }
        protected ISwim _swim { get; }
        protected IQuack _quack { get; }

        public Duck(IFly fly, ISwim swim, IQuack quack)
        {
            _fly = fly == null ? throw new ArgumentNullException() : fly;
            _swim = swim == null ? throw new ArgumentNullException() : swim;
            _quack = quack == null ? throw new ArgumentNullException() : quack;
        }

        public string DuckFly()
        {
            return _fly.Fly();
        }

        public string DuckSwim()
        {
            return _swim.Swim();
        }

        public string DuckQuack()
        {
            return _quack.Quack();
        }
    }
}
