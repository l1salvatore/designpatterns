using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.AbstractFactory
{
    public class Client
    {
        private IAbstractProductA abstractProductA;
        private IAbstractProductB abstractProductB;
        public Client(IAbstractFactory factory)
        {
            abstractProductA = factory.CreateProductA();
            abstractProductB = factory.CreateProductB();
        }
        public void Run()
        {
            abstractProductB.OperationB();
            abstractProductA.OperationA();
        }
    }
}
