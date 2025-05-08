using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.ChainOfResponsability
{
    public class Client
    {
        IHandler my_handler;
        public Client()
        {
            my_handler = new ConcreteHandler1();
            my_handler.SetNext(new ConcreteHandler2());
        }
        public void Run()
        {
            my_handler.Handle("50");


        }
    }
}
