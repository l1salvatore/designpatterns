using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Iterator
{
    interface IAggregate
    {
        IIterator<int> CreateIterator();
    }
}
