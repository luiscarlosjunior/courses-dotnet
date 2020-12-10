using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Singleton.GetInstace();
            var s2 = Singleton.GetInstace();

            if (s1 == s2)
            {
                System.Console.WriteLine("Singleton works, both variable contain the same instance.");
            }  
            else
            {
                System.Console.WriteLine("Singleton failed, variable contain different instances.");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
