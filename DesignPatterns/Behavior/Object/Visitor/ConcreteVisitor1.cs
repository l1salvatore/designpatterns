using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Visitor
{
    public class ConcreteVisitor1 : Visitor.IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            concreteElementA.SomeOperationA();
        }
        public void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            concreteElementB.SomeOperationB();
        }
    }  
}
