using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Decorator
{
    public class Client
    {
        IComponent component;
        
        public Client()
        {
            component = new ConcreteDecoratorA(new ConcreteComponent());

        }
        public void Run()
        {
            component.Operation();

        }
    }
}
