using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.ObserverPattern.Model.ObserverModel
{
    public class GreenLED : Observer
    {
        private bool _on = false;
        public override void Update()
        {
            _on = !_on;
            Console.WriteLine($"GreenLED is:{((_on) ?"ON" : "OFF")}");
           

        }
    }
}
