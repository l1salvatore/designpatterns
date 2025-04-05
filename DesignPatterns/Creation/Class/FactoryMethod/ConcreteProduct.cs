﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Class.FactoryMethod
{
    public class ConcreteProduct : IProduct
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
