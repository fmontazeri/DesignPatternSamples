using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.Strategy.Model;

namespace DesignPatternApp.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationManager add = new OperationManager(new OperationAdd());
            var a =  add.executeOperation(2, 3);
            Console.WriteLine(a);

            OperationManager substract = new OperationManager(new OperationSubstract());
            var b =  substract.executeOperation(5, 3);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
