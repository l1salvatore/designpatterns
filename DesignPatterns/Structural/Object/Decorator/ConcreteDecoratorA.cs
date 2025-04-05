using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component)
        {
        }
        public new void Operation()
        {
            Console.WriteLine("ConcreteDecoratorA.Operation");
            base.Operation();
        }
    }  

}
