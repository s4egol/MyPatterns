using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Behaviors_Patterns.Strategy
{
    public class Man
    {
        public int Age { get; private set; }
        public string Name { get; private set; }
        public IStrategy Strategy { private get; set; }

        public Man(int age, string name, IStrategy strategy)
        {
            if (strategy == null)
                throw new ArgumentNullException();
            if (age < 0 || string.IsNullOrEmpty(name))
                throw new ArgumentException();

            Age = age;
            Name = name;
            Strategy = strategy;
        }

        public void UseDatabase()
        {
            Strategy.DoIt();
        }

    }
}
