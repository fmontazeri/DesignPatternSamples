using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [Lazy instantiation and Thread-Safe singleton]


            Console.WriteLine("Before Instantiate 1!");
            var instance1 = Singleton.Instance;
            Console.WriteLine("After Instantiate 1!");

            Console.WriteLine("*** Create second instance! ***");

            Console.WriteLine("Before Instantiate 2!");
            var instance2 = Singleton.Instance;
            Console.WriteLine("After Instantiate 2!");
            #endregion

            Console.WriteLine("/////////////////////////////////");

            #region [not quite as lazy, but thread-safe without using locks]
            Console.WriteLine("Before Instantiate 3");
            var instance3 = Singleton1.Instance;
            Console.WriteLine("After Instantiate 3");

            Console.WriteLine("*** Create second instance! ***");

            Console.WriteLine("Before Instantiate 4");
            var instance4 = Singleton1.Instance;
            Console.WriteLine("After Instantiate 4");
            #endregion

            Console.ReadLine();

        }
    }
}
