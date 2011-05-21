namespace AOP.Console
{
    using Common;

    public class ServiceFactory
    {
        public IService Create()
        {
            return new Service();
        }
    }
}