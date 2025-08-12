using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Strategy
{
    public interface IStrategy
    {
        public void AlgorithmInterface(ref int[] array);
    }
}
