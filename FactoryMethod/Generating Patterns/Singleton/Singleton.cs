using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Generating_Patterns.Singleton
{
    public class Singleton
    {
        private static Singleton instance { get; set; }
        private static object obj = new object();

        public int SomeField { get; set; }

        private Singleton()
        {
            SomeField = 15;
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock(obj)
                {
                    if (instance == null)
                        instance = new Singleton();
                }
            }
            return instance;
        }
    }
}
