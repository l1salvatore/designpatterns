using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Mediator
{
    public abstract class Colleague
    {
        public IMediator myMediator;
        public Colleague(IMediator med) {
            myMediator = med;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);

    }
}
