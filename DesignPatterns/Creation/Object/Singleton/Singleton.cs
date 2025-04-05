using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation.Object.Singleton
{
    public class Singleton
    {
        static Singleton? unique_instance;
        public int Data { get; set; }
        private Singleton()
        {
            
            Data = 0;
        }
        public static Singleton GetInstance()
        {
            if (unique_instance == null)
            {
                unique_instance = new Singleton();
            }
            return unique_instance;
        }

        public void Operation()
        {
            Data++;
        }
    }
}
