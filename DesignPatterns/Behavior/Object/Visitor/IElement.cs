using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Visitor
{
    public interface IElement
    {
        /// <summary>
        /// Accepts a visitor to perform operations on the element.
        /// </summary>
        /// <param name="visitor">The visitor that will perform operations on the element.</param>
        void Accept(IVisitor visitor);
    }
}
