using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSingleton
{
    class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton getInstance
        {
            get { 
                if(instance == null)
                    instance = new Singleton();
                return instance; 
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value is " + counter.ToString());
            
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
