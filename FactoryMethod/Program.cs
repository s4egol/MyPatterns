using FactoryMethod.Behaviors_Patterns.Observer;
using FactoryMethod.Behaviors_Patterns.Strategy;
using FactoryMethod.Behaviors_Patterns.Template_method;
using FactoryMethod.FactoryMethod;
using FactoryMethod.Generating_Patterns.Singleton;
using FactoryMethod.Structural_Patterns.Facade;
using FactoryMethod.Structural_Patterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Factory Method----------");
            var bird1 = BirdFactory.CreateBird("cROw");
            Console.Write("Voice bird : ");
            bird1.GetVoice();

            Console.WriteLine("----------Singleton----------");
            Singleton instanceSingleton = Singleton.GetInstance();
            Console.WriteLine("Value SomeField in first object : {0} ", instanceSingleton.SomeField);
            instanceSingleton.SomeField += 5;
            Console.WriteLine("Changed value SomeField in first object : {0} ", instanceSingleton.SomeField);
            Singleton instanceSingleton2 = Singleton.GetInstance();
            Console.WriteLine("Value SomeField in second object : {0} ", instanceSingleton2.SomeField);

            Console.WriteLine("----------Strategy----------");
            Man man = new Man(22, "Ivan", new ConcreteStrategy1());
            man.UseDatabase();
            man.Strategy = new ConcreteStrategy2();
            man.UseDatabase();

            Console.WriteLine("----------Fasad----------");
            VisualStudioFasad fasad = new VisualStudioFasad(new CLR(), new Compiller());
            Console.WriteLine("Execute operation1:");
            fasad.Operation1();
            Console.WriteLine();
            Console.WriteLine("Execute operation2:");
            fasad.Operation2();

            Console.WriteLine("----------Template method----------");
            List<Shop> shops = new List<Shop>() { new FirstShop("FirstShop"), new SecondShop("SecondShop")};
            shops.ForEach(x => x.Operation1());

            Console.WriteLine("----------Observer----------");
            var bank = new Bank();
            var client1 = new Client("Metesky", bank);
            var client2 = new Client("Kot", bank);
            bank.ChangeCurrencies();
            bank.ChangeCurrencies();

            Console.WriteLine("----------Proxy----------");
            Subject proxy = new Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }

    
}
