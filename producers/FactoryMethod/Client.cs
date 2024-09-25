
namespace FactoryMethod
{
    public abstract class Client
    {
        private Creator _creator;
        public Client(Creator creator)
        {
            _creator = creator;
        }
    }
}