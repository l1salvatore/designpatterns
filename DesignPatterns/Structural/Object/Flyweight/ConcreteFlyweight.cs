using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Flyweight
{
    public class ConcreteFlyweight : IFlyweight
    {
        private string _state;
        public ConcreteFlyweight(string intrinsicState)
        {
            _state = intrinsicState;
        }
        public string Name => _state;
        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"ConcreteFlyweight: {_state} - {extrinsicState}");
        }
    }
}
