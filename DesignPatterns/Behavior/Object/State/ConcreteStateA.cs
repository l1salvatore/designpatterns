using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.State
{
    class ConcreteStateA : IState
    {
        private Context myContext;
        public ConcreteStateA(Context context) {
            myContext = context;
        }

        public void Handle()
        {
            Console.WriteLine($"On State A, i will do 1+1: {1 + 1}");
            myContext.TransitionToB();
        }
    }
}
