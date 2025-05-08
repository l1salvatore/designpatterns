using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavior.Object.Command
{
    public class Receptor
    {
        public Receptor() { }

        public void Action()
        {
           Console.WriteLine("Executing Action");
        }
    }
}
