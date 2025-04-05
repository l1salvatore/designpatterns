using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Class.FactoryMethod
{
    public class ConcreteCreator : Creator
    {
        public override IProduct fabricationMethod()
        {
            return new ConcreteProduct { Name = "Rueda", Description = "Para la camioneta" };
        }


    }
}
