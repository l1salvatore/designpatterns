using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.Prototype
{
    public interface IPrototype
    {
        public string Data { get; set; }
        public List<int> Numbers { get; set; }

        public IPrototype clone();
    }
}
