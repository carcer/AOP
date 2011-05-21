namespace AOP.Common
{
    using System;
    using System.IO;

    public class Service : IService
    {
        public void DoSomething(TextWriter output, string value)
        {
            if (value.Equals("flu"))
                throw new InvalidOperationException();

            output.WriteLine("Doing something awesome with {0}", value);
        }
    }
}