using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Composite
{
    public class Client
    {
        IComponent component;
        
        public Client()
        {
            component = new Compound();

        }
        public void Run()
        {
            component.Add(new Leaf());
            component.Add(new Compound());
            component.GetChild(1).Add(new Leaf1());
            component.GetChild(1).Add(new Leaf2());
            component.GetChild(0).Operation();
            component.GetChild(1).GetChild(0).Operation();
            component.GetChild(1).GetChild(1).Operation();

        }
    }
}
