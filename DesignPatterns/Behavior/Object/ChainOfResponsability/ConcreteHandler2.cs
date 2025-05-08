using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.ChainOfResponsability
{
   public class ConcreteHandler2 : IHandler
    {
        private IHandler _nextHandler;
        public void SetNext(IHandler successor)
        {
            _nextHandler = successor;
        }
        public void Handle(string request)
        {
            if (request == "10" || request == "20")
            {
                Console.WriteLine("ConcreteHandler2 handled request " + request);
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
