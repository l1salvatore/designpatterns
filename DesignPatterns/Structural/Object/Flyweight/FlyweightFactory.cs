using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Flyweight
{
    public class FlyweightFactory
    {
        public FlyweightFactory() { }
        private Dictionary<string, IFlyweight> _flyweights = new Dictionary<string, IFlyweight>();
        public IFlyweight GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights.Add(key,new ConcreteFlyweight(key));
            }
            return _flyweights[key];
        }

    }
    
}
