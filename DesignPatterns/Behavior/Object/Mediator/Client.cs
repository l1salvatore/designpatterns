using DesignPatterns.Behavior.Object.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Mediator
{
    public class Client
    {

        public Client() { }

        public void Run()
        {
            // Create a mediator
            IMediator mediator = new ConcreteMediator();
            // Create colleagues and register them with the mediator
            Colleague colleague1 = new ConcreteColleague1(mediator);
            Colleague colleague2 = new ConcreteColleague2(mediator);
            // Send messages between colleagues
            colleague1.Send("A");
            colleague2.Send("B");
            colleague1.Send("C"); // Unknown message



        }
    }
}
