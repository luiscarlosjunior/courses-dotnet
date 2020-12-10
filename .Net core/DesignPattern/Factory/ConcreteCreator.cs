namespace Factory
{
    public class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }

    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}