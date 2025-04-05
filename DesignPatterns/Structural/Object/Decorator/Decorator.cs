using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Decorator
{
    public class Decorator : IComponent
    {
        private readonly IComponent _component;
        public Decorator(IComponent component)
        {
            _component = component;
        }
        public void Operation()
        {
            Console.WriteLine("Decorator.Operation");
            _component.Operation();
        }
    }

}
