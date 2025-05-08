using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Command
{
    public class ConcreteOrder : IOrder
    {
        private Receptor _receptor;
        public ConcreteOrder(Receptor receptor)
        {
            _receptor = receptor;
        }
        public void Execute()
        {
            _receptor.Action();
        }
    }  
}
