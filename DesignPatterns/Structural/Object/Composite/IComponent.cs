using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Composite
{
    public interface IComponent
    {
        public void Operation();
        public void Add(IComponent component);
        public void Remove(IComponent component);
        public IComponent GetChild(int index);

    }
}
