using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Structural_Patterns.Proxy
{
    public class Proxy : Subject
    {
        private RealObject realObject;

        public override void Request()
        {
            if (realObject == null)
                realObject = new RealObject();

            Console.WriteLine("Request to RealObject from Proxy");
            realObject.Request();
        }
    }
}
