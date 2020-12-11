namespace Decorator
{
    public abstract class Decorator : Component
    {
        protected Component _component;
        
        public Decorator(Component component)
        {
            _component = component;
        }

        public void SetComponent(Component component)    
        {
            _component = component;
        }

        // The decorator delegates all work to the wrapped component
        public override string Operation()
        {
            if (_component != null)
            {
                return _component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}