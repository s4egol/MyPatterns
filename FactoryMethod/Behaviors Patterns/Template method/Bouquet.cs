using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Behaviors_Patterns.Template_method
{
    public class Bouquet
    {
        public int CountOfFlowers { get; set; }
        public int PriceInDollars { get; set; }
        public bool Wrapper { get; set; }

        public Bouquet(int countOfFlowers, int priceInDollars, bool wrapper)
        {
            if (countOfFlowers <= 0 || priceInDollars <= 0)
                throw new ArgumentException();

            CountOfFlowers = countOfFlowers;
            PriceInDollars = priceInDollars;
            Wrapper = wrapper;
        }
    }
}
