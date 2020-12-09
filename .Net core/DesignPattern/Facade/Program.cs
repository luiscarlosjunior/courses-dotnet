using System;

namespace Facade
{
    /// <summary>
    /// Facade é um padrão estrutural que fornece uma interface
    /// simplificada para um sistema complexo de classes, biblioteca
    /// ou framework
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            var subsystem1 = new Subsystem1();
            var subsystem2 = new Subsystem2();
            var facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
}
