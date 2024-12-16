namespace Proxy
{
    public interface IMyFile
    {
        string GetPath();

        byte[] ReadAll();

        long Size();
    }
}
