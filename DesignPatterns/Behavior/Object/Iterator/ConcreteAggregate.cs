using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Iterator
{
    class ConcreteAggregate : IAggregate
    {
        private int[] items = new int[] {3,8,2,4,6,9,2 };
        public IIterator<int> CreateIterator()
        {
            return new ConcreteIterator(items);

        }
    }
}
