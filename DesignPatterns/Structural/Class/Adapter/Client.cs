using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Class.Adapter
{
    public class Client
    {
        IObjective objective;
        ConcreteAdaptable concreteadaptable;
        public Client()
        {
            concreteadaptable = new ConcreteAdaptable();
            objective = new Adapter(concreteadaptable);
        }
        public void Run()
        {
            objective.Request();

        }
    }
}
