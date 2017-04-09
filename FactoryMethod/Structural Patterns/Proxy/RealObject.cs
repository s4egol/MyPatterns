using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Structural_Patterns.Proxy
{
    public class RealObject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Hello from RealObject!");
        }
    }
}
