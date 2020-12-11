using System;

// O Decorator é um padrão estrutural que permite adicionar 
// novos comportamentos aos objetos dinamicamente, colocando-os dentro de objetos wrapper especiais.

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            var simple = new ConcreteComponent();
            System.Console.WriteLine("Client: I get a simple component");
            client.ClientCode(simple);
            System.Console.WriteLine();

            var decorator1 = new ConcreteDecoratorA(simple); 
            var decorator2 = new ConcreteDecoratorB(decorator1); 
            System.Console.WriteLine("Client: Now I've got a decorated component: ");
            client.ClientCode(decorator2);
        }
    }
}
