using DesignPatterns.Behavior.Object.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Behavior.Object.Strategy
{
    public class Client
    {

        public Client() { }

        public void Run()
        {
            Context context = new Context();

            int[] array = new int[] { 5, 3, 8, 6, 2 };
            context.ContextInterface(ref array);
        }
    }
}
