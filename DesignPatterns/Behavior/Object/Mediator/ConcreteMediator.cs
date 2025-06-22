using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Mediator
{

    public class ConcreteMediator : IMediator
    {
        private List<Colleague> colleagues = new List<Colleague>();
        public void Register(Colleague colleague)
        {
            colleagues.Add(colleague);
        }
        public void Send(string message, Colleague sender)
        {
            if (message == "A")
            {
                Console.WriteLine("ConcreteMediator received message 'A' from " + sender.GetType().Name);
                foreach (var colleague in colleagues)
                {
                    if (colleague != sender)
                    {
                        colleague.Receive("Message A processed by " + colleague.GetType().Name);
                    }
                }
            }
            else if (message == "B")
            {
                Console.WriteLine("ConcreteMediator received message 'B' from " + sender.GetType().Name);
                foreach (var colleague in colleagues)
                {
                    if (colleague != sender)
                    {
                        colleague.Receive("Message B processed by " + colleague.GetType().Name);
                    }
                }
            }
            else
            {
                Console.WriteLine("ConcreteMediator received unknown message: " + message);
            }
        }
    }
}
