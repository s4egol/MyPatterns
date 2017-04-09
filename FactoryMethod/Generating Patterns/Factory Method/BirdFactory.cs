using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryMethod
{
    public static class BirdFactory
    {
        private static Dictionary<string, Func<Bird>> map = new Dictionary<string, Func<Bird>>();

        static BirdFactory()
        {
            map.Add("CROW", () => new Crow());
            map.Add("SPARROW", () => new Sparrow());
        }

        public static Bird CreateBird(string typeBird)
        {
            typeBird = typeBird.ToUpper();
            var bird = GetValueFromRepository(typeBird);
            if (bird == null)
                throw new ArgumentException();
            return bird();
        }

        private static Func<Bird> GetValueFromRepository(string key)
        {
            Func<Bird> createBird;
            map.TryGetValue(key, out createBird);
            return createBird;
        }
    }
}
