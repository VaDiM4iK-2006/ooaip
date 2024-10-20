using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ITable CreateTable();
        ISofa CreateSofa();
    }
}
