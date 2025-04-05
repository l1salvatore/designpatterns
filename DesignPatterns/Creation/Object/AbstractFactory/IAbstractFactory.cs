﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.AbstractFactory
{
    public interface IAbstractFactory
    {
        public IAbstractProductA CreateProductA();

        public IAbstractProductB CreateProductB();
    }
}
