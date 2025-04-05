﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.AbstractFactory
{
    public class ProductB1 : IAbstractProductB
    {
        public void OperationB()
        {
            Console.WriteLine("ProductB1.OperationB");
        }
    }
}
