using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Flyweight
{
    public class Client
    {
       
        public Client() { }
        public void Run()
        {
            FlyweightFactory factory = new FlyweightFactory();
            IFlyweight flyweight1 = factory.GetFlyweight("A");
            IFlyweight flyweight2 = factory.GetFlyweight("B");
            IFlyweight flyweight3 = factory.GetFlyweight("A");
            flyweight1.Operation("1");
            flyweight2.Operation("2");
            flyweight3.Operation("3");
        }

    }
}
