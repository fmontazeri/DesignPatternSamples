using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService service = new UserService();
            var user = service.GetUser("maryam");

            if(user.Authenticated)
            Console.WriteLine($"username:{user.UserName}");


            var user2 = service.GetUser("zahra");
            if(user2.Authenticated)
                Console.WriteLine($"Username:{user.UserName} is authenticated!");
            Console.ReadLine();
        }
    }
}
