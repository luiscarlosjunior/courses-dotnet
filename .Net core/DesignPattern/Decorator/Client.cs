namespace Decorator
{
    public class Client
    {
        public void ClientCode(Component component)
        {
            System.Console.WriteLine("Result: " + component.Operation());
        }
    }
}