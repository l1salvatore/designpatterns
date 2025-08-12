using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Visitor
{
    public interface IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
}
