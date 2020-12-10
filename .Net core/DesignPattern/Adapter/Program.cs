using System;

namespace Adapter
{
    /// <summary>
    /// O Adapter é um padrão de projeto estrutural, que permite a colaboração de objetos incompatíveis
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            
            System.Console.WriteLine("Adaptee interface is incompatible with the client.");
            System.Console.WriteLine("But with adapter client can call it's method.");
            
            Console.WriteLine("Hello World!");
        }
    }
}
