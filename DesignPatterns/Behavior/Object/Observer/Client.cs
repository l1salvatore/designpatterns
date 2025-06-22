using DesignPatterns.Behavior.Object.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Observer
{
    public class Client
    {

        public Client() { }

        public void Run()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver1 obs1 = new ConcreteObserver1(subject);
            ConcreteObserver2 obs2 = new ConcreteObserver2(subject);
            subject.AddObserver(obs1);
            subject.AddObserver(obs2); 

            subject.Data = "New State";
            



        }
    }
}
