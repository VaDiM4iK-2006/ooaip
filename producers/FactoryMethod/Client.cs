
namespace FactoryMethod
{
    public abstract class Client
    {
        public string Create()
        {
            var sofa = CreateSofa();
            var chair = CreateChair();
            var table = CreateTable();
            return $"{sofa}{chair}{table}";
        }
        protected abstract ISofa CreateSofa();
        protected abstract IChair CreateChair();
        protected abstract ITable CreateTable();
    }
}