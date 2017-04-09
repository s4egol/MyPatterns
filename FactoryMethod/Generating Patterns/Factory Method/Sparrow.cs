using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryMethod
{
    public class Sparrow : Bird //воробей
    {
        public override void GetVoice()
        {
            Console.WriteLine("Chick-chirick");
        }
    }
}
