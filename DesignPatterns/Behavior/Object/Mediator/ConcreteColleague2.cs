using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Mediator
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(IMediator med) : base(med) 
        {
            myMediator.Register(this);
        }
        public override void Send(string message)
        {
            Console.WriteLine($"ConcreteColleague2 sending message: {message}");
            // Logic to send message through mediator would go here
            myMediator.Send(message, this);

        }
        public override void Receive(string message)
        {
            Console.WriteLine($"ConcreteColleague2 received message: {message}");
        }
    }
}
