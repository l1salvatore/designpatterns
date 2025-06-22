using DesignPatterns.Behavior.Object.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.State
{
    public class Client
    {

        public Client() { }

        public void Run()
        {
            Context context = new Context();

            context.Request();
            context.Request();
            context.Request();


        }
    }
}
