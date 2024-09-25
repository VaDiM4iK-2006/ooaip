using System.ComponentModel.DataAnnotations.Schema;

namespace FactoryMethod
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ITable CreateTable();
        ISofa CreateSofa();
    }
}
