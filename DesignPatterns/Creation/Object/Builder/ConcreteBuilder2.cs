using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.Builder
{
    public class ConcreteBuilder2 : IBuilder
    {
        object build;
        public void BuildPart()
        {
            build = "hello world";
        }

        public object ObtainResults()
        {
            return build;
        }
    }
}
