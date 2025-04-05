using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Class.FactoryMethod
{
    public class Client
    {
        Creator my_creator;
        public Client()
        {
            my_creator = new ConcreteCreator();
        }
        public void Run()
        {
           Console.WriteLine(my_creator.fabricationMethod().Name);
           Console.WriteLine(my_creator.fabricationMethod().Description);

        }
    }
}
