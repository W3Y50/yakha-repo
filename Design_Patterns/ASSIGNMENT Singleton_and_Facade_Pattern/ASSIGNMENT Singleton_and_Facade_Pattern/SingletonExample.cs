using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_Singleton_and_Facade_Pattern
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private Singleton()
        {
            // Private constructor to prevent direct instantiation
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void DoSomething()
        {
            // Singleton logic goes here
            Console.WriteLine("Doing something in the Singleton.");
        }
    }
}
