using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data 
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Bolid an egg", Line="Boli water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Cut bread", Line="get a knife", Platform="knife & chopping board"},
                new Command{Id=2, HowTo="Bolid an egg", Line="Boli water", Platform="Kettle & Pan"}

            };
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Bolid an egg", Line="Boli water", Platform="Kettle & Pan"};
        }
    }
}