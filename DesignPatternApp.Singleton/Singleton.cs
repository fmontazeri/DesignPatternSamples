using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Singleton
{

    //The laziness of type initializers is only guaranteed by .NET when the type isn't marked with a special flag called beforefieldinit.
    //Unfortunately, the C# compiler (as provided in the .NET 1.1 runtime, at least) marks all types which don't have a static constructor
    //(i.e. a block which looks like a constructor but is marked static) as beforefieldinit.

    //Note that all of these implementations also use a public static property Instance as the means of accessing the instance.
    //In all cases, the property could easily be converted to a method, with no impact on thread-safety or performance.

    //The class is sealed
    public sealed class Singleton
    {
        //A public static means of getting the reference to the single created instance, creating one if necessary.
        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("Get Instance!");
                return NestedClass.instance;
            }
        }

        //A single constructor, which is private and parameterless
        private Singleton()
        {
            Console.WriteLine("Run Private ctor of Singleton!");
        }

        private class NestedClass
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static NestedClass()
            {
                Console.WriteLine("Run Static ctor of NestedClass!");
            }

            //A static variable which holds a reference to the single created instance, if any.
            internal static readonly Singleton  instance = new Singleton();
        }
    }


    public sealed class Singleton1
    {
        private static readonly Singleton1 instance = new Singleton1();

        public static Singleton1 Instance
        {
            get
            {
                Console.WriteLine("Get Instance!");
                return instance;
            }
        }

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton1()
        {
            Console.WriteLine("static ctor!");
        }

        private Singleton1()
        {
            Console.WriteLine("private ctor!");
        }

    }
}

