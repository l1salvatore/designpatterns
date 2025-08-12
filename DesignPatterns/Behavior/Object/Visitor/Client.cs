using DesignPatterns.Behavior.Object.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Behavior.Object.Visitor
{
    public class Client
    {

        public Client() { }

        public void Run()
        {
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Someperation();
        }
    }
}
