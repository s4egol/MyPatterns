using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Structural_Patterns.Facade
{
    public class VisualStudioFasad
    {
        private CLR clr; //subsystem1
        private Compiller compiller; //subsystem2

        public VisualStudioFasad(CLR clr, Compiller compiller)
        {
            if (clr == null || compiller == null)
                throw new ArgumentNullException();

            this.clr = clr;
            this.compiller = compiller;
        }

        public void Operation1()
        {
            compiller.Compile();
            clr.Execute();
        }

        public void Operation2()
        {
            clr.Finish();
        }
    }
}
