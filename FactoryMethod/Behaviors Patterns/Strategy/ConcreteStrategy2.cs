using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Behaviors_Patterns.Strategy
{
    public class ConcreteStrategy2 : IStrategy
    {
        public void DoIt()
        {
            Console.WriteLine("The person works with the database 2");
        }
    }
}
