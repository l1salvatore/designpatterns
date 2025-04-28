using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Decorator
{
    /// <summary>
    /// Decorator class that adds additional functionality to the component.
    /// Decorator implements the same interface as the component.
    /// Decorator contains a reference to the component and delegates calls to it.
    /// </summary>
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
