using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.State
{
    class ConcreteStateB : IState
    {
        private Context myContext;
        public ConcreteStateB(Context context)
        {
            myContext = context;
        }


        public void Handle()
        {
            Console.WriteLine($"On State B, i will do 2+5: {2 + 5}");
            myContext.TransitionToA();
        }
    }
}
