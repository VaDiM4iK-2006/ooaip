namespace ChainOfResponsibility
{
    public interface IHandler
    {
        string Handle(object handler, string type);
    }
}
