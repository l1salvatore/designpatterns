using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Proxy
{
    public class Client
    {
        ISubject subject;
        public Client()
        {
            // Create a proxy for the real subject
            subject = new Proxy();
        }
        public void Run()
        {
            // Call the operation on the proxy
            subject.Request();
        }
    }
}
