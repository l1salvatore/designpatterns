using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.Singleton
{
    public class Client
    {
        public Client()
        {
        }
        public void Run()
        {
            Singleton.GetInstance().Operation();
            Console.WriteLine($"{Singleton.GetInstance().Data}");
        }
    }
}
