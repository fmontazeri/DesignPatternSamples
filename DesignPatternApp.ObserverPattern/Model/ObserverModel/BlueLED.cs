using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.ObserverPattern.Model.ObserverModel
{
   public class BlueLED: Observer
   {
       private bool _on = false;
        public override void Update()
        {
            _on = !_on;
            Console.WriteLine($"BlueLED is:{((_on) ? "ON" : "OFF")}");
        }
    }
}
