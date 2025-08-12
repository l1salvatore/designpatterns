using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Strategy
{
    public class ConcreteStrategyB : IStrategy
    {
        public void AlgorithmInterface(ref int[] array)
        {
            Array.Reverse(array);
            Console.WriteLine("ConcreteStrategyB: Sorted array in reverse order.");
        }
    }
}
