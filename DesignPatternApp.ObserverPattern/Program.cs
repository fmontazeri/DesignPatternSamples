using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternApp.ObserverPattern.Model.ObservableModel;
using DesignPatternApp.ObserverPattern.Model.ObserverModel;

namespace DesignPatternApp.ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var redLed = new RedLED();
            var blueLed = new BlueLED();
            var greenLed = new GreenLED();

            var Switch = new Switch();
            Switch.Attach(redLed);
            Switch.Attach(blueLed);
            Switch.Attach(greenLed);

            //Turn On Switch
            Switch.State = true;
            //Turn Off Switch
            Switch.State = false;

            //Detach Leds 
            Switch.Dettach(redLed);
            Switch.Dettach(blueLed);
            Switch.Dettach(greenLed);

            Console.ReadLine();
        }
    }
}
