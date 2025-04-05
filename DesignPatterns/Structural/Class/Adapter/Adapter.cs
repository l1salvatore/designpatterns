using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Class.Adapter
{
    public class Adapter : IObjective
    {
        private IAdaptable _adaptable;

        public Adapter(IAdaptable adaptable)
        {
            _adaptable = adaptable;
        }

        public void Request()
        {
            _adaptable.AnotherRequest();
        }
    }
}
