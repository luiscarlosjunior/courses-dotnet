namespace Facade
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem
    public class Facade
    {
        protected Subsystem1 _Subsystem1;
        protected Subsystem2 _Subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _Subsystem1 = subsystem1;
            _Subsystem2 = subsystem2;
        }

        // The Facade's methods are convenient shortcuts
        // to the sophisticated functionality.
        public string Operation()
        {
            string result = "Facade initializes subsystem:\n";
            result += _Subsystem1.Operation1();
            result += _Subsystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += _Subsystem1.OperationN();
            result += _Subsystem2.OperationN();
            return result;
        }

    }
}