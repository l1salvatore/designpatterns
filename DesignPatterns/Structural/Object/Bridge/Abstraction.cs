using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Bridge
{
    public class Abstraction
    {
        protected IImplementor Implementor { get; set; }

        public Abstraction(IImplementor implementor)
        {
            Implementor = implementor;
        }
        public void Operation()
        {
            Implementor.OperationImp();
        }
    }
}
