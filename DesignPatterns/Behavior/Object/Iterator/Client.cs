using DesignPatterns.Behavior.Object.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Iterator
{
    public class Client
    {

        public Client() { }

        public void Run()
        {
            IAggregate aggregate = new ConcreteAggregate();
            IIterator<int> iterator = aggregate.CreateIterator();

            Console.WriteLine($"First {iterator.First()}");
            Console.WriteLine($"Next {iterator.Next()}");
            Console.WriteLine($"Next {iterator.Next()}");


        }
    }
}
