using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Class.Template_Method
{
    public class Client
    {
        public Client() { }
        public void Run()
        {
            // Create an instance of a concrete class that extends the abstract class
            ConcreteClass concreteClass = new ConcreteClass();
            concreteClass.TemplateMethod();
        }
    }
}