using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Flyweight
{
    public class ConcreteNoSharedFlyweight : IFlyweight
    {
        private string _state;
        public ConcreteNoSharedFlyweight(string state)
        {
            _state = state;
        }
        public string Name => _state;

        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"ConcreteNoSharedFlyweight: State = {_state}, Extrinsic State = {extrinsicState}");
        }
    }
}
