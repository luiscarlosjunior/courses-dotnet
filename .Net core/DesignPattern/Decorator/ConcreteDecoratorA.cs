namespace Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component comp) : base(comp) {}

        public override string Operation() 
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}