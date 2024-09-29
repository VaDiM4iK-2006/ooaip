using System.ComponentModel.DataAnnotations.Schema;

namespace Singleton
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ITable CreateTable();
        ISofa CreateSofa();
    }
}
