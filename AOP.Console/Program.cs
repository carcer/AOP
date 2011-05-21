namespace AOP.Console
{
    using System.Diagnostics;
    using Common;
    using Console = System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

            Console.Write("Give me something awesome: ");

            string somethingAwesome = Console.ReadLine();

            IService service = CreateService();

            service.DoSomething(Console.Out, somethingAwesome);

            Console.Read();
        }

        private static IService CreateService()
        {
            var factory = new ServiceFactory();
            return factory.Create();
        }
    }
}
