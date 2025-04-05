using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.Builder
{
    public class Client
    {
        private ConcreteBuilder2 builder;
        private Director director;
        public Client()
        {
            builder = new ConcreteBuilder2();
            director = new Director(builder);
        }
        public void Run()
        {
            director.Construct();
            string? result = builder.ObtainResults()?.ToString();
            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("object not built");
            }
        }
    }
}
