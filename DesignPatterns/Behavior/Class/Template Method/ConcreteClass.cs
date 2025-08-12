using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Class.Template_Method
{
    public class ConcreteClass : AbstractClass
    {
        public ConcreteClass() { }
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
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClass: Performing Primitive Operation 1.");
        }
        /// <summary>
        /// Another primitive operation that must be implemented by subclasses.
        /// </summary>
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClass: Performing Primitive Operation 2.");
        }
        /// <summary>
        /// Hook method that can be overridden by subclasses.
        /// </summary>
        public override void Hook()
        {
            Console.WriteLine("ConcreteClass: Executing hook method.");
        }
    }

}
