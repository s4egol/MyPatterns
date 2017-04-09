using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Behaviors_Patterns.Template_method
{
    public class FirstShop : Shop
    {
        public FirstShop(string nameShop) : base(nameShop)
        {

        }

        protected override Bouquet ChooseTheBestBouquet()
        {
            return bouquets.First(x => x.Wrapper == true);
        }
    }
}
