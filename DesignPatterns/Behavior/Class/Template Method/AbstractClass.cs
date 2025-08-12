using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Class.Template_Method
{
    public abstract class AbstractClass
    {
        /// <summary>
        /// Template method defining the skeleton of an algorithm.
        /// </summary>
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Hook();
        }
        /// <summary>
        /// Primitive operation that must be implemented by subclasses.
        /// </summary>
        public abstract void PrimitiveOperation1();
        /// <summary>
        /// Another primitive operation that must be implemented by subclasses.
        /// </summary>
        public abstract void PrimitiveOperation2();
        /// <summary>
        /// Hook method that can be overridden by subclasses.
        /// </summary>
        public virtual void Hook() { }
    }
}
