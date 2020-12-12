namespace Factory
{
    // The Creator class declares the factory method that is supposed to return
    // an object of a Product class. The Creator's subclasses usually provide
    // the implementation of this method.
    public abstract class Creator
    {
        //Note that the Creator may also provide some default implementation of the 
        // factory method
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            // Call the factory method to create a Product object
            var product = FactoryMethod();
            // Now, use the product
            var result = "Creator: trhe same creator's code has just worked woth " +
             product.Operation();

            return result;
        }

    }
}