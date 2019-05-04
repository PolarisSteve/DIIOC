using System;
using static InterfaceClass.Interfaces;

namespace HelloWorldClass
{
    public class HelloWorld : IHelloWorld
    {
        public string DisplayHello { get { return "Hello World"; } }
    }
}
