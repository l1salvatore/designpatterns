using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Mediator
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(IMediator med) : base(med)
        {
            myMediator.Register(this);
        }

        public override void Send(string message)
        {
            Console.WriteLine($"ConcreteColleague1 sending message: {message}");
            // Logic to send message through mediator would go here
            myMediator.Send(message, this);
        }
        public override void Receive(string message)
        {
            Console.WriteLine($"ConcreteColleague1 received message: {message}");
        }
    }
}
