using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Object.Facade
{
    public class Client
    {
        
        public Client()
        {

        }
        public void Run()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            // Wait for user
            Console.ReadKey();
        }
    }
}
