using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Composite
{
    public class Leaf2 : IComponent
    { 
        public void Operation()
        {
            Console.WriteLine("Leaf2 operation");
        }
        public void Add(IComponent component)
        {
            throw new NotImplementedException();
        }
        public void Remove(IComponent component)
        {
            throw new NotImplementedException();
        }
        public IComponent GetChild(int index)
        {
            throw new NotImplementedException();
        }
    }
}
