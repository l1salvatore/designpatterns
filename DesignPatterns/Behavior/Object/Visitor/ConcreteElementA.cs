using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Visitor
{
    public class ConcreteElementA : IElement
    {
      
        public ConcreteElementA() { }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
        public void SomeOperationA()
        {
            // Implementation of some operation specific to ConcreteElementA
            Console.WriteLine("ConcreteElementA: Performing some operation.");
        }
    }
}