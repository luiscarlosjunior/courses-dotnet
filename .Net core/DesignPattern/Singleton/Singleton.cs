namespace Singleton
{
    
    // The Singleton class defines the `GetInstance` method that serves as an
    // alternative to constructor and lets clients access the same instance of
    // this class over and over
    public class Singleton
    {
        private Singleton() {}

        private static Singleton _instance;

        public static Singleton GetInstace()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        
    // Finally, any singleton shoulddefine some business logic
    // which can be executed on its instance
        public static void someBusinessLogic()
        {
            ///
        }
    }

}