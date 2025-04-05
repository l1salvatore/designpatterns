using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Decorator
{
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation");
        }
    }
   
}
