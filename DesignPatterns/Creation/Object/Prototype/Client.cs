using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.Prototype
{
    public class Client
    {
        private IPrototype prototype;
        public Client()
        {
            prototype = new ConcretePrototype1
            {
                Data = "Example",
                Numbers = new List<int> { 1, 2, 3 }
            };
        }
        public void Run()
        {
            var clonedPrototype = prototype.clone();
            if (clonedPrototype != null)
            {
                clonedPrototype.Numbers.Add(4);

                Console.WriteLine("Cloned: ");

                Console.WriteLine(clonedPrototype.Data);
                Console.WriteLine(string.Join(", ", clonedPrototype.Numbers));

                Console.WriteLine("Original: ");
                Console.WriteLine(prototype.Data);
                Console.WriteLine(string.Join(", ", prototype.Numbers));
            }
        }
    }
}
