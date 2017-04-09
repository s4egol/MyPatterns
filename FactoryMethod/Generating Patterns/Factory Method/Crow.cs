using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryMethod
{
    public class Crow : Bird //ворона
    {
        public override void GetVoice()
        {
            Console.WriteLine("Kar-kar-kar");
        }
    }
}
