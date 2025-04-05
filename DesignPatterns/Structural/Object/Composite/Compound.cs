using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Composite
{
    public class Compound : IComponent
    {
        private List<IComponent> _children = new List<IComponent>();
        public void Operation()
        {
            Console.WriteLine("Compound operation");
            foreach (var child in _children)
            {
                child.Operation();
            }
        }
        public void Add(IComponent component)
        {
            _children.Add(component);
        }
        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }
        public IComponent GetChild(int index)
        {
            return _children[index];
        }
    }
}
