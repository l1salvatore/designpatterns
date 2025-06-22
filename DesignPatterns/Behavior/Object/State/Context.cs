using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.State
{
    public class Context
    {
        private IState myState;

        public Context()
        {
            myState = new ConcreteStateA(this);
        }

        public void Request()
        {
            myState.Handle();
        }

        public void TransitionToB()
        {
            myState = new ConcreteStateB(this);
        }

        public void TransitionToA()
        {
            myState = new ConcreteStateA(this);
        }

    }
}
