using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Behaviors_Patterns.Observer
{
    public class Bank : IObservable
    {
        private List<IObserver> observers;
        private Currencies currencies;

        public Bank()
        {
            observers = new List<IObserver>();
            currencies = new Currencies() { USDInRub = 60, EURInRub = 65 };
        }

        public void NotifyObservers()
        {
            observers.ForEach(x => x.Update(currencies));
        }

        public void RegisterObserver(IObserver obj)
        {
            if (obj == null)
                throw new ArgumentNullException();

            observers.Add(obj);
        }

        public void RemoveObserver(IObserver obj)
        {
            if (obj == null)
                throw new ArgumentNullException();

            observers.Remove(obj);
        }

        public void ChangeCurrencies()
        {
            var random = new Random();
            currencies.USDInRub = random.Next(60, 65);
            currencies.EURInRub = random.Next(66, 73);
            NotifyObservers();
        }
    }
}
