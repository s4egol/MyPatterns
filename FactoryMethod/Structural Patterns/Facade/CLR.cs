using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Structural_Patterns.Facade
{
    public class CLR
    {
        public void Execute() =>
            Console.WriteLine("Run the application");

        public void Finish() =>
            Console.WriteLine("Finish the application");

        //Other methods
    }
}
