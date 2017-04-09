using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Behaviors_Patterns.Observer
{
    public class Client : IObserver
    {
        public string SecondName { get; private set; }
        private IObservable observable;

        public Client(string secondName, IObservable observable)
        {
            if (observable == null)
                throw new ArgumentNullException();

            this.observable = observable;
            SecondName = secondName;
            observable.RegisterObserver(this);
        }

        public void Update(object obj)
        {
            var currencies = obj as Currencies;
            if (currencies != null)
            {
                Console.WriteLine("Client {0} got message: ", SecondName);
                Console.WriteLine("1 USD = {0}", currencies.USDInRub);
                Console.WriteLine("1 EUR = {0}", currencies.EURInRub);
            }
        }
    }
}
