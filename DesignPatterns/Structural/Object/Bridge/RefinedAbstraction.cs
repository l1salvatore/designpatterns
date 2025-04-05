using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor implementor) : base(implementor)
        {
        }

        public void RefinedOperation1()
        {
            // Implementación de RefinedOperation1
        }

        public void RefinedOperation2()
        {
            // Implementación de RefinedOperation2
        }
    }
}
