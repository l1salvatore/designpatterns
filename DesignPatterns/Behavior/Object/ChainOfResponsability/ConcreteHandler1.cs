using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.ChainOfResponsability
{
    public class ConcreteHandler1 : IHandler
    {
        private IHandler _nextHandler;
        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }
        public void Handle(string request)
        {
            if (request == "30")
            {
                Console.WriteLine("ConcreteHandler1 handled the request.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine("No handler found for the request.");
            }
        }
    }
}
