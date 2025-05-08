using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Command
{
    public class Client
    {

        public Client() { }

        public void Run()
        {
            Receptor receptor = new Receptor();
            Invoker invoker = new Invoker();
            // Create a command
            IOrder order = new ConcreteOrder(receptor);
            // Add the command to the invoker
            invoker.AddOrder(order);        
        }
    }
}
