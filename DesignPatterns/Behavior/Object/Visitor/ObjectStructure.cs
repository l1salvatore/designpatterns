using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Visitor
{
    public class ObjectStructure
    {
        private List<IElement> _elements = new List<IElement>();

        public ObjectStructure()
        {
            _elements = new List<IElement>
            {
                new ConcreteElementA(),
                new ConcreteElementB()
            };
        }

        public void Someperation()
        {
            // Iterate through the elements and accept the visitor
            foreach (var element in _elements)
            {
                // Here we would typically pass a visitor to the element
                // For example: element.Accept(visitor);
                element.Accept(new ConcreteVisitor2());
                element.Accept(new ConcreteVisitor1());
            }
        }
    }
}
