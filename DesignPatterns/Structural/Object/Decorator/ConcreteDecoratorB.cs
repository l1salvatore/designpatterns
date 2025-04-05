using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Decorator
{

    public class ConcreteDecoratorB : Decorator
    {
        public bool addedstate = false;
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }
        public new void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorB.Operation");
            addedstate = true;
        }
    }

}
