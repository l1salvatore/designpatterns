using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Strategy
{
    public class ConcreteStrategyC : IStrategy
    {
        public void AlgorithmInterface(ref int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("ConcreteStrategyC: Sorted array using built-in sort.");
        }
    }
}
