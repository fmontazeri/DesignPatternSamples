using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.Facade.Model
{
    public class SmsManager
    {
        public void SendMessage(int phoneNumber)
        {
            Console.WriteLine("Please take back the book to the library : " + phoneNumber);
        }
    }
}
