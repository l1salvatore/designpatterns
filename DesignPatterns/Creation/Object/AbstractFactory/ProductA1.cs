using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.AbstractFactory
{
    public class ProductA1 : IAbstractProductA
    {
        public void OperationA()
        {
            Console.WriteLine("ProductA1.OperationA");
        }
    }
}
