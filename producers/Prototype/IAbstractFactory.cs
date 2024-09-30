using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype
{
    public interface IAbstractFactory
    {
        IPrototype CreateChair();
        IPrototype CreateTable();
        IPrototype CreateSofa();
    }
}
