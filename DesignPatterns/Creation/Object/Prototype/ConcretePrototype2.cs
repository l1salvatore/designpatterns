using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.Prototype
{
    public class ConcretePrototype1 : IPrototype
    {
        public string Data { get; set; }
        public List<int> Numbers { get; set; } = new();

        public IPrototype clone()
        {
            return new ConcretePrototype1
            {
                Data = this.Data,
                Numbers = new List<int>(this.Numbers)
            };
        }
    }
}
