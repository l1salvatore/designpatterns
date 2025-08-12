using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Strategy
{
    public class Context
    {
        private IStrategy strategy;
        public Context()
        {
            strategy = new ConcreteStrategyA();
        }
        public void ContextInterface(ref int[] array)
        {
            strategy.AlgorithmInterface(ref array);
        }


    }
}
