using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Flyweight
{
    public interface IFlyweight
    {
        string Name { get; }
        void Operation(string extrinsicState);
    }
}
