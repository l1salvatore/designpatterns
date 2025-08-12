using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Visitor
{
    public class ConcreteElementB : IElement
    {
      
        public ConcreteElementB() { }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
        public void SomeOperationB()
        {
            // Implementation of some operation specific to ConcreteElementB
            Console.WriteLine("ConcreteElementB: Performing some operation.");
        }
    }
}