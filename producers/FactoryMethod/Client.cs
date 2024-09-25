
namespace FactoryMethod
{
    public abstract class Client
    {
        private Creator _creator;
        public Client(Creator creator)
        {
            _creator = creator;
        }
        public void Execution()
        {
            string chair = _creator.ProcessChair();
            string table = _creator.ProcessTable();
            string sofa = _creator.ProcessSofa();
        }
    }
}