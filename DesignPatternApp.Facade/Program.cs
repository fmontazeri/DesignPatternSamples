using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.Facade.Model;

namespace DesignPatternApp.Facade
{
    class Program
    {
    
        static void Main(string[] args)
        {
           
            var mayFacade = new FacadeBookLoan();
            var loansCount =  mayFacade.IsLoanable(100);
            Console.WriteLine(loansCount > 0 ? "You can loan the book " : "You cant loan the book!");

            var loansCount2 = mayFacade.IsLoanable(200);
            Console.WriteLine(loansCount2 > 0 ? "You can loan the book " : "You can not loan the book!");
            Console.ReadLine();

        }
    }
}
