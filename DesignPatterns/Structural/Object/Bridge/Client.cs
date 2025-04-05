using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Bridge
{
    public class Client
    {
        Abstraction abstraction;
        
        public Client()
        {
            abstraction = new Abstraction(new ConcreteImplementor1());

        }
        public void Run()
        {
           abstraction.Operation();
        }
    }
}
