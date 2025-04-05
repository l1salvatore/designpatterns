using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.Builder
{
    public class ConcreteBuilder1 : IBuilder
    {
        object build;
        public void BuildPart()
        {
            build = "hola mundo";
        }

        public object ObtainResults()
        {
            return build;
        }
    }
}
