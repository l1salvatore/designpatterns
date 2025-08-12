using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Visitor
{
    public class ConcreteVisitor2 : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            // Implementation for visiting ConcreteElementA
            Console.WriteLine("ConcreteVisitor2: Visiting ConcreteElementA");
        }
        public void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            // Implementation for visiting ConcreteElementB
            Console.WriteLine("ConcreteVisitor2: Visiting ConcreteElementB");
        }
    }
}
