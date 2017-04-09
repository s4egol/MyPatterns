using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Behaviors_Patterns.Template_method
{
    public abstract class Shop
    {
        protected List<Bouquet> bouquets;
        public string NameShop { get; set; }

        public Shop(string nameShop)
        {
            if (string.IsNullOrEmpty(nameShop))
                throw new ArgumentException();

            NameShop = nameShop;
            bouquets = new List<Bouquet>();
        }

        protected void OrderBatchOfFlowers()
        {
            bouquets.Add(new Bouquet(10, 5, false));
            bouquets.Add(new Bouquet(8, 7, true));
            bouquets.Add(new Bouquet(12, 5, true));
            Console.WriteLine("A batch of flowers was ordered successfully");
        }

        protected abstract Bouquet ChooseTheBestBouquet();

        protected void GiveBouquetToTheBuyer(Bouquet bouquet)
        {
            Console.WriteLine("The bouquet ( {0} flowers, {1}$ price and wrapper - {2} ) give to the buyer", 
                bouquet.CountOfFlowers, bouquet.PriceInDollars, bouquet.Wrapper);
        }

        public void Operation1()
        {
            OrderBatchOfFlowers();
            Bouquet bouquet = ChooseTheBestBouquet();
            GiveBouquetToTheBuyer(bouquet);
        }
    }
}
