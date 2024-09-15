using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        public abstract IChair CreateChair();
        public abstract ITable CreateTable();
        public abstract ISofa CreateSofa();
    }
}
