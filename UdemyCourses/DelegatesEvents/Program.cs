using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    //Microsft definition
    /// <summary>
    /// Delegates: A delegate is a type that represents references to methods 
    /// with a particular parameter list and return type. When you instantiate 
    /// a delegate, you can associate its instance with any method with a
    /// compatible signature and return type. You can invoke (or call) the 
    /// method through the delegate instance
    /// </summary>
    class Program
    {
        /*
        public delegate double PerformCalculation(double a, double b);

        public static double Addition(double a, double b)
        {
            Console.WriteLine("a+b is: " + (a+b));
            return a + b;
        }

        public static double Division(double a, double b)
        {
            Console.WriteLine("a/b is: " + (a / b));
            return a / b;
        }
        */

        public delegate string GetTextDelegate(string name);

        static void Main(string[] args)
        {
            /*    
            PerformCalculation getSum = Addition;
            PerformCalculation getDiv = Division;
            PerformCalculation multCast = getSum + getDiv;
            multCast(5f, 6f);
            */

            //Anonymous delegate
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello, " + name;
            };

            // Expression lambda
            GetTextDelegate getTextDelegate1 = name => "Luis Carlos";

            // Statement lambda
            GetTextDelegate getTextDelegate2 = (string name) =>
            {
                Console.WriteLine("I'm inside lambda");
                return "Hi";
            };

            Console.WriteLine(getTextDelegate("Luis Santos"));
            Display(getTextDelegate);
        }

        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("Hi"));
        }

    }
}
