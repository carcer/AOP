namespace AOP.Common
{
    using System.IO;

    public interface IService
    {
        void DoSomething(TextWriter output, string value);
    }
}
